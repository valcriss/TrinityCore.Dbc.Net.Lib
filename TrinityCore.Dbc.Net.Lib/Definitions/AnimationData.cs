using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AnimationData.dbc")]
    public class AnimationData : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Name { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint WeaponFlags { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint BodyFlags { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
        public uint Fallback { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
        public uint Behavior { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
        public uint BehaviorTier { get; set; }
    }
}
