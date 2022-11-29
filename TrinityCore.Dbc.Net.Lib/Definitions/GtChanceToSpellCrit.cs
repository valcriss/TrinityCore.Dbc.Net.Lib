using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("gtChanceToSpellCrit.dbc")]
    public class GtChanceToSpellCrit : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Float)]
        public float Data { get; set; }

     }
}
