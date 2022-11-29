using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SummonProperties.dbc")]
    public class SummonProperties : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Control { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Faction { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Title { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int Slot { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

        public FactionTemplate? GetFactionFactionTemplate()
        {
               return DbcDirectory.Open<FactionTemplate>()?.Where(c => c.Id == this.Faction).FirstOrDefault();
        }

     }
}
