using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SkillTiers.dbc")]
    public class SkillTiers : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 16)]
        public int[]? Cost { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 16)]
        public int[]? Value { get; set; }

     }
}
