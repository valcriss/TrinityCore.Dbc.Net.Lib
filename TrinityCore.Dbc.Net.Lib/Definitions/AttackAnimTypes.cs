using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AttackAnimTypes.dbc")]
    public class AttackAnimTypes : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint AnimId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string AnimName { get; set; }
    }
}
