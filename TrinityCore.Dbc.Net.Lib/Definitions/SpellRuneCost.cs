using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SpellRuneCost.dbc")]
    public class SpellRuneCost : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Blood { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Unholy { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Frost { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int RunicPower { get; set; }

     }
}
