using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("BannedAddOns.dbc")]
    public class BannedAddOns : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 4)]
        public int[]? NameMD5 { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 4)]
        public int[]? VersionMD5 { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int LastModified { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

     }
}
