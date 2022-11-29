using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("LFGDungeonExpansion.dbc")]
    public class LFGDungeonExpansion : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int LfgId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int ExpansionLevel { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int RandomId { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int HardLevelMin { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Int32)]
        public int HardLevelMax { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.Int32)]
        public int TargetLevelMin { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.Int32)]
        public int TargetLevelMax { get; set; }

     }
}
