using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("EmotesText.dbc")]
    public class EmotesText : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Name { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int EmoteId { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfUint32, 16)]
        public int[]? EmoteText { get; set; }

        public Emotes? GetEmoteIdEmotes()
        {
               return DbcDirectory.Open<Emotes>()?.Where(c => c.Id == this.EmoteId).FirstOrDefault();
        }

        public EmotesTextData[]? GetEmoteTextEmotesTextDatas()
        {
               return DbcDirectory.Open<EmotesTextData>()?.Where(c => this.EmoteText != null && this.EmoteText.Contains(c.Id)).ToArray();
        }

     }
}
