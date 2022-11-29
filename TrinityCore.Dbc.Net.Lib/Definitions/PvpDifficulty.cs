using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("PvpDifficulty.dbc")]
    public class PvpDifficulty : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int MapId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int RangeIndex { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int MinLevel { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int MaxLevel { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Int32)]
        public int Difficulty { get; set; }

        public Map? GetMapIdMap()
        {
               return DbcDirectory.Open<Map>()?.Where(c => c.Id == this.MapId).FirstOrDefault();
        }

     }
}
