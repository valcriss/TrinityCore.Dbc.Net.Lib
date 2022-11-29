using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("UnitBloodLevels.dbc")]
    public class UnitBloodLevels : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 3)]
        public int[]? Violencelevel { get; set; }

     }
}
