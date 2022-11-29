using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("PetitionType.dbc")]
    public class PetitionType : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Name { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Type { get; set; }

     }
}
