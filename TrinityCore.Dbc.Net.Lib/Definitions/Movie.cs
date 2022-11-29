using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Movie.dbc")]
    public class Movie : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Filename { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Volume { get; set; }

     }
}
