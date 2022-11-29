using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("gtChanceToSpellCritBase.dbc")]
    public class GtChanceToSpellCritBase : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Float)]
        public float Data { get; set; }

     }
}
