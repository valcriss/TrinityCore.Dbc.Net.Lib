using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Achievement.dbc")]
    public class Achievement : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Faction { get; set; }

        [DbcColumn(2,Enums.DbcColumnDataType.UInt32)]
        public uint Map { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint Previous { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Loc)]
        public string? Name { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Loc)]
        public string? Description { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
        public uint Category { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
        public uint Points { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
        public uint OrderInCategory { get; set; }

        [DbcColumn(9, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }

        [DbcColumn(10, Enums.DbcColumnDataType.UInt32)]
        public uint SpellIcon { get; set; }

        [DbcColumn(11, Enums.DbcColumnDataType.Loc)]
        public string? Reward { get; set; }

        [DbcColumn(12, Enums.DbcColumnDataType.UInt32)]
        public uint MinCriteriaDemanded { get; set; }

        [DbcColumn(13, Enums.DbcColumnDataType.UInt32)]
        public uint LinkedAchievement { get; set; }
    }
}
