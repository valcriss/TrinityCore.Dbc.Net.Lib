using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ScalingStatDistribution.dbc")]
    public class ScalingStatDistribution : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 10)]
        public int[]? StatId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 10)]
        public int[]? Bonus { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Maxlevel { get; set; }

     }
}
