using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SpellRadius.dbc")]
    public class SpellRadius : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Float)]
        public float Radius { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Float)]
        public float RadiusPerLevel { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Float)]
        public float RadiusMax { get; set; }

     }
}
