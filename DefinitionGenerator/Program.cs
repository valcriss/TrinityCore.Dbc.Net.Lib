// See https://aka.ms/new-console-template for more information

using DefinitionGenerator;

string dbcDirectory = @"C:\Users\silve\Documents\Unity\wowData\3.3.5\dbc";
string definitionsDirectory = @"C:\Users\silve\Documents\GitHub\WoWDBDefs\definitions";
string sourceCodeDirectory = @"C:\Users\silve\source\repos\TrinityCore.Dbc.Net.Lib\TrinityCore.Dbc.Net.Lib\Definitions\";



foreach (string dbcfile in Directory.GetFiles(dbcDirectory, "*.dbc"))
{
    string sourceCodeFilename = Path.GetFileNameWithoutExtension(dbcfile).Replace("_", "") + ".cs";
    if (!File.Exists(Path.Combine(sourceCodeDirectory, sourceCodeFilename)))
    {
        string definitionFilename = Path.GetFileNameWithoutExtension(dbcfile) + ".dbd";
        if (File.Exists(Path.Combine(definitionsDirectory, definitionFilename)))
        {
            ConsoleHelper.WriteInfo("- Generating [" + sourceCodeFilename + "]");
            ConsoleHelper.WriteInfo("- Loading definitions");
            Definition definition = new Definition(Path.Combine(definitionsDirectory, definitionFilename));
            List<FieldDefinition> fields = definition.LoadBuild("3.3.5.12340");
            if(fields.Count > 0)
            {
                ConsoleHelper.WriteSuccess("- FieldDefinitions found");
                FieldDefinition.WriteFields(fields, Path.Combine(sourceCodeDirectory, sourceCodeFilename));
            }
            else
            {
                ConsoleHelper.WriteError("- FieldDefinitions not found");
            }

            ConsoleHelper.WriteInfo("");

            break;
        }
       
    }
}

