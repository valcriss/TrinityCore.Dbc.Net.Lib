using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionGenerator
{
    public class FieldDefinition
    {
        public string? Name { get; set; }
        public string? DataType { get; set; }
        public string? PropertyType { get; set; }
        public string? ArrayCount { get; set; }



        public static void WriteFields(List<FieldDefinition> fields, string filename)
        {
            string f = Path.GetFileNameWithoutExtension(filename);
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("using System;");
            builder.AppendLine("using System.Collections.Generic;");
            builder.AppendLine("using System.Linq;");
            builder.AppendLine("using System.Text;");
            builder.AppendLine("using System.Threading.Tasks;");
            builder.AppendLine("using TrinityCore.Dbc.Net.Lib.Attributes;");
            builder.AppendLine("");
            builder.AppendLine("namespace TrinityCore.Dbc.Net.Lib.Definitions");
            builder.AppendLine("{");
            builder.AppendLine($"   [DbcFile(\"{f + ".dbc"}\")]");
            builder.AppendLine($"   public class {f} : DbcFile");
            builder.AppendLine("    {");
            for (int i = 0; i < fields.Count; i++)
            {
                FieldDefinition? field = fields[i];
                if (string.IsNullOrEmpty(field.ArrayCount))
                {
                    builder.AppendLine($"      [DbcColumn({i}, Enums.DbcColumnDataType.{field.DataType})]");
                }
                else
                {
                    builder.AppendLine($"      [DbcColumn({i}, Enums.DbcColumnDataType.{field.DataType}, {field.ArrayCount})]");
                }

                builder.AppendLine($"      public {field.PropertyType} {field.Name} " + "{ get; set; }");
                builder.AppendLine("");
            }
            builder.AppendLine("    }");
            builder.AppendLine("}");

            File.WriteAllText(filename, builder.ToString());
        }
    }
}
