using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Package.dbc")]
    public class Package : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Icon { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Cost { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

     }
}
