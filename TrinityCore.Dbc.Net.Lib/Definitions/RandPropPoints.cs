using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("RandPropPoints.dbc")]
    public class RandPropPoints : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 5)]
        public int[]? Epic { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 5)]
        public int[]? Superior { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfUint32, 5)]
        public int[]? Good { get; set; }

     }
}
