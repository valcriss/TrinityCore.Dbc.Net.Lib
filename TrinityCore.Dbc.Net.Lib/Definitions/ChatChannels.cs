using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ChatChannels.dbc")]
    public class ChatChannels : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int FactionGroup { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Loc)]
        public string? Shortcut { get; set; }

     }
}
