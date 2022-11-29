using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CharBaseInfo.dbc")]
    public class CharBaseInfo : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Byte)]
        public byte RaceId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Byte)]
        public byte ClassId { get; set; }

        public ChrRaces? GetRaceIdChrRaces()
        {
               return DbcDirectory.Open<ChrRaces>()?.Where(c => c.Id == this.RaceId).FirstOrDefault();
        }

        public ChrClasses? GetClassIdChrClasses()
        {
               return DbcDirectory.Open<ChrClasses>()?.Where(c => c.Id == this.ClassId).FirstOrDefault();
        }

     }
}
