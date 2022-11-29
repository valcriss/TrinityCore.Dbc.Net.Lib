using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("PowerDisplay.dbc")]
    public class PowerDisplay : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int ActualType { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.StringRef)]
        public string? GlobalStringBaseTag { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Byte)]
        public byte Red { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Byte)]
        public byte Green { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Byte)]
        public byte Blue { get; set; }

     }
}
