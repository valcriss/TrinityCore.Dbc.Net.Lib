using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("UnitBlood.dbc")]
    public class UnitBlood : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 2)]
        public int[]? CombatBloodSpurtFront { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 2)]
        public int[]? CombatBloodSpurtBack { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfStringRef, 5)]
        public string[]? GroundBlood { get; set; }

     }
}
