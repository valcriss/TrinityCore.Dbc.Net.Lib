using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("UISoundLookups.dbc")]
    public class UISoundLookups : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int SoundId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.StringRef)]
        public string? SoundName { get; set; }

        public SoundEntries? GetSoundIdSoundEntries()
        {
               return DbcDirectory.Open<SoundEntries>()?.Where(c => c.Id == this.SoundId).FirstOrDefault();
        }

     }
}
