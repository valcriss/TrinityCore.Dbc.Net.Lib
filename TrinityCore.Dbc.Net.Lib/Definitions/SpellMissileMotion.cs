using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SpellMissileMotion.dbc")]
    public class SpellMissileMotion : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Name { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.StringRef)]
        public string? ScriptBody { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int MissileCount { get; set; }

     }
}
