using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("PaperDollItemFrame.dbc")]
    public class PaperDollItemFrame : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.StringRef)]
        public string? ItemButtonName { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? SlotIcon { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int SlotNumber { get; set; }

     }
}
