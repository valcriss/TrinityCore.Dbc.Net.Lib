using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("GMSurveySurveys.dbc")]
    public class GMSurveySurveys : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 10)]
        public int[]? Q { get; set; }

        public GMSurveyQuestions[]? GetQGMSurveyQuestionss()
        {
               return DbcDirectory.Open<GMSurveyQuestions>()?.Where(c => this.Q != null && this.Q.Contains(c.Id)).ToArray();
        }

     }
}
