using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Cfg_Categories.dbc")]
    public class CfgCategories : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint LocaleMask { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint CharsetMask { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Loc)]
        public string Name { get; set; }

    }
}
