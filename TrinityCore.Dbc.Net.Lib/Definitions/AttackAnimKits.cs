using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AttackAnimKits.dbc")]
    public class AttackAnimKits : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint AnimationData { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint AttackAnimTypes { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Bool)]
        public bool WhichHand { get; set; }
    }
}
