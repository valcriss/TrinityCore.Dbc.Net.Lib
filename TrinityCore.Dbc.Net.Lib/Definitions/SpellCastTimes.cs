using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SpellCastTimes.dbc")]
    public class SpellCastTimes : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Base { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int PerLevel { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Minimum { get; set; }

     }
}
