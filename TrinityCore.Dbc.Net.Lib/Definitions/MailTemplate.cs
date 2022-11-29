using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("MailTemplate.dbc")]
    public class MailTemplate : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Loc)]
        public string? Subject { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Loc)]
        public string? Body { get; set; }

     }
}
