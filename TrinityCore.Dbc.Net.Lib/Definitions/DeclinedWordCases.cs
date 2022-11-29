using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("DeclinedWordCases.dbc")]
    public class DeclinedWordCases : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int DeclinedWordId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int CaseIndex { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.StringRef)]
        public string? DeclinedWord { get; set; }

        public DeclinedWord? GetDeclinedWordIdDeclinedWord()
        {
               return DbcDirectory.Open<DeclinedWord>()?.Where(c => c.Id == this.DeclinedWordId).FirstOrDefault();
        }

     }
}
