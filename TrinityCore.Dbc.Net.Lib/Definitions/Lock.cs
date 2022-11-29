using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Lock.dbc")]
    public class Lock : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 8)]
        public int[]? Type { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 8)]
        public int[]? Index { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfUint32, 8)]
        public int[]? Skill { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.ArrayOfUint32, 8)]
        public int[]? Action { get; set; }

     }
}
