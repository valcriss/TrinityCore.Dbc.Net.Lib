using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("gtOCTClassCombatRatingScalar.dbc")]
    public class GtOCTClassCombatRatingScalar : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Float)]
        public float Data { get; set; }

     }
}
