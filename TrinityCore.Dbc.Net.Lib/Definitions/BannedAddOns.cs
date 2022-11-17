using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("BannedAddOns.dbc")]
    public class BannedAddOns : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32,4)]
        public uint[]? NameMD5 { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 4)]
        public uint[]? VersionMD5 { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint LastModified { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }
    }
}
