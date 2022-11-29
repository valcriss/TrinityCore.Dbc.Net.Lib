using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("GroundEffectDoodad.dbc")]
    public class GroundEffectDoodad : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Doodadpath { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

     }
}
