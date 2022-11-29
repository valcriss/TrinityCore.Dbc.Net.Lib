using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("DurabilityCosts.dbc")]
    public class DurabilityCosts : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 21)]
        public int[]? WeaponSubClassCost { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 8)]
        public int[]? ArmorSubClassCost { get; set; }

     }
}
