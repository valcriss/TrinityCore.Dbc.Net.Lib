using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("LightFloatBand.dbc")]
    public class LightFloatBand : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Num { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 16)]
        public int[]? Time { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfFloat, 16)]
        public float[]? Data { get; set; }

     }
}
