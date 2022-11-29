using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("GMSurveyAnswers.dbc")]
    public class GMSurveyAnswers : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int SortIndex { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int GMSurveyQuestionId { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? Answer { get; set; }

        public GMSurveyQuestions? GetGMSurveyQuestionIdGMSurveyQuestions()
        {
               return DbcDirectory.Open<GMSurveyQuestions>()?.Where(c => c.Id == this.GMSurveyQuestionId).FirstOrDefault();
        }

     }
}
