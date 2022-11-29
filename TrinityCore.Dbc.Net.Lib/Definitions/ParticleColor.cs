using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ParticleColor.dbc")]
    public class ParticleColor : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 3)]
        public int[]? Start { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 3)]
        public int[]? MId { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfUint32, 3)]
        public int[]? End { get; set; }

     }
}
