using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("GMSurveyCurrentSurvey.dbc")]
    public class GMSurveyCurrentSurvey : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int LANGId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int GMSURVEYId { get; set; }

        public GMSurveySurveys? GetGMSURVEYIdGMSurveySurveys()
        {
               return DbcDirectory.Open<GMSurveySurveys>()?.Where(c => c.Id == this.GMSURVEYId).FirstOrDefault();
        }

     }
}
