using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("gtOCTRegenHP.dbc")]
    public class GtOCTRegenHP : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Float)]
        public float Data { get; set; }

     }
}
