using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AttackAnimTypes.dbc")]
    public class AttackAnimTypes : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int AnimId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? AnimName { get; set; }

     }
}
