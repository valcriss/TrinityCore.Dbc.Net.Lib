using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("gtOCTRegenMP.dbc")]
    public class GtOCTRegenMP : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Float)]
        public float Data { get; set; }

     }
}
