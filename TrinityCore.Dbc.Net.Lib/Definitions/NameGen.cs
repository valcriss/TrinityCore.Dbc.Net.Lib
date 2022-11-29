using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("NameGen.dbc")]
    public class NameGen : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Name { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int RaceId { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Sex { get; set; }

        public ChrRaces? GetRaceIdChrRaces()
        {
               return DbcDirectory.Open<ChrRaces>()?.Where(c => c.Id == this.RaceId).FirstOrDefault();
        }

     }
}
