using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("GroundEffectTexture.dbc")]
    public class GroundEffectTexture : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 4)]
        public int[]? DoodadId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 4)]
        public int[]? DoodadWeight { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Density { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int Sound { get; set; }

     }
}
