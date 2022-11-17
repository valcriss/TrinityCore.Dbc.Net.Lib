using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DefinitionGenerator
{
    public class Definition
    {
        private string Filename { get; set; }
        public Definition(string filename)
        {
            Filename = filename;
        }

        public List<FieldDefinition> LoadBuild(string build)
        {
            bool opened = false;
            string[] lines = File.ReadAllLines(Filename);
            List<string> definitionLines = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (opened == false && line.Contains("BUILD") && line.Contains(build))
                {
                    opened = true;
                }
                else if (opened == true && line.Contains("BUILD") && definitionLines.Count > 0)
                {
                    opened = false;
                }
                else if (opened && !line.Contains("BUILD"))
                {
                    if (line.Trim().Length > 0)
                        definitionLines.Add(line);
                }
            }
            List<FieldDefinition> fields = new List<FieldDefinition>();
            bool allGood = true;
            foreach (string definitionLine in definitionLines)
            {
                if (definitionLine.StartsWith("LAYOUT")) continue;
                if (definitionLine.Equals("$id$ID<32>"))
                {
                    fields.Add(new FieldDefinition() { Name = "Id", PropertyType = "uint", DataType = "UInt32", ArrayCount = null });
                    continue;
                }
                if (definitionLine.Equals("Pos[3]") || definitionLine.Equals("Origin[3]"))
                {
                    fields.Add(new FieldDefinition() { Name = "X", PropertyType = "float", DataType = "Float", ArrayCount = null });
                    fields.Add(new FieldDefinition() { Name = "Y", PropertyType = "float", DataType = "Float", ArrayCount = null });
                    fields.Add(new FieldDefinition() { Name = "Z", PropertyType = "float", DataType = "Float", ArrayCount = null });
                    continue;
                }
                if (definitionLine.Equals("OriginFacing"))
                {
                    fields.Add(new FieldDefinition() { Name = "Facing", PropertyType = "float", DataType = "Float", ArrayCount = null });
                    continue;
                }
                if (definitionLine.Equals("Model"))
                {
                    fields.Add(new FieldDefinition() { Name = "Model", PropertyType = "string?", DataType = "StringRef", ArrayCount = null });
                    continue;
                }
                if (definitionLine.EndsWith("Scale"))
                {
                    fields.Add(new FieldDefinition() { Name = definitionLine, PropertyType = "float", DataType = "Float", ArrayCount = null });
                    continue;
                }
                if (definitionLine.Equals("TextureVariation[3]"))
                {
                    fields.Add(new FieldDefinition() { Name = "TextureVariation", PropertyType = "string[]?", DataType = "ArrayOfStringRef", ArrayCount = "3" });
                    continue;
                }
      
                if (definitionLine.Equals("PortraitTextureName") || definitionLine.Equals("BakeName") || definitionLine.Equals("IconFile"))
                {
                    fields.Add(new FieldDefinition() { Name = definitionLine, PropertyType = "string?", DataType = "StringRef", ArrayCount = null });
                    continue;
                }

                Match match = Regex.Match(definitionLine, @"(.+)<(.+)>\[(.+)\]");
                if (match.Success) // Is an array value
                {
                    string name = match.Groups[1].Value;
                    string datatypeCode = match.Groups[2].Value;
                    string propertyType = "uint[]?";
                    string datatype = "ArrayOfUint32";
                    if (datatypeCode == "32")
                    {
                        propertyType = "uint[]?";
                        datatype = "ArrayOfUint32";
                    }
                    string arrayCount = match.Groups[3].Value;
                    fields.Add(new FieldDefinition() { Name = name, PropertyType = propertyType, DataType = datatype, ArrayCount = arrayCount });
                    continue;
                }
                Match matchsolo = Regex.Match(definitionLine, @"(.+)<(.+)>");
                if (matchsolo.Success) // Is an array value
                {
                    string name = matchsolo.Groups[1].Value;
                    string datatypeCode = matchsolo.Groups[2].Value;
                    string propertyType = "uint";
                    string datatype = "UInt32";
                    if (datatypeCode == "32")
                    {
                        propertyType = "uint";
                        datatype = "UInt32";
                    }
                    fields.Add(new FieldDefinition() { Name = name, PropertyType = propertyType, DataType = datatype, ArrayCount = null });
                    continue;
                }

                if (definitionLine.EndsWith("_lang"))
                {
                    fields.Add(new FieldDefinition() { Name = definitionLine.Replace("_lang", ""), PropertyType = "string?", DataType = "Loc", ArrayCount = null });
                    continue;
                }
                ConsoleHelper.WriteError("No rule found for : " + definitionLine);
                allGood = false;
            }
            if (!allGood) fields.Clear();
            return fields;
        }
    }
}
