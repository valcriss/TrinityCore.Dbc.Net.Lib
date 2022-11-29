using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("MapDifficulty.dbc")]
    public class MapDifficulty : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int MapId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Difficulty { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? Message { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int RaidDuration { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Int32)]
        public int MaxPlayers { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.StringRef)]
        public string? Difficultystring { get; set; }

        public Map? GetMapIdMap()
        {
               return DbcDirectory.Open<Map>()?.Where(c => c.Id == this.MapId).FirstOrDefault();
        }

     }
}
