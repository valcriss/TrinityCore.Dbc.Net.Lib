using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Achievement_Category.dbc")]
    public class AchievementCategory : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint ParentId { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? Name { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint OrderInUI { get; set; }
    }
}
