using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SkillCostsData.dbc")]
    public class SkillCostsData : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int SkillCostsId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 3)]
        public int[]? Cost { get; set; }

     }
}
