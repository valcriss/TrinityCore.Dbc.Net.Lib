using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SpellDuration.dbc")]
    public class SpellDuration : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Duration { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int DurationPerLevel { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int MaxDuration { get; set; }

     }
}
