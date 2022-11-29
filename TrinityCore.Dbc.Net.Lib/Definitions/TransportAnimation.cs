using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("TransportAnimation.dbc")]
    public class TransportAnimation : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int TransportId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int TimeIndex { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfFloat, 3)]
        public float[]? Pos { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int SequenceId { get; set; }

     }
}
