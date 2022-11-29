using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("LockType.dbc")]
    public class LockType : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Loc)]
        public string? ResourceNameLang { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? Verb { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.StringRef)]
        public string? CursorName { get; set; }

     }
}
