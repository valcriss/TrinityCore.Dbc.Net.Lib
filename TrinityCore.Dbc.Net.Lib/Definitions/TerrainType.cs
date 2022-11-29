using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("TerrainType.dbc")]
    public class TerrainType : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int TerrainId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? TerrainDesc { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int FootstepSprayRun { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int FootstepSprayWalk { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int SoundId { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

     }
}
