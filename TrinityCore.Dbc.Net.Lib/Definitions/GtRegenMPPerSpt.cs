using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("gtRegenMPPerSpt.dbc")]
    public class GtRegenMPPerSpt : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Float)]
        public float Data { get; set; }

     }
}
