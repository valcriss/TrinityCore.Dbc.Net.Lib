using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("FileData.dbc")]
    public class FileData : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Filename { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.StringRef)]
        public string? Filepath { get; set; }

     }
}
