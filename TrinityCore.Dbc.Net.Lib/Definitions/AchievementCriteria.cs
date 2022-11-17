using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Achievement_Criteria.dbc")]
    public class AchievementCriteria : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Achievement { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint Type { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint ReqAssetID { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
        public uint ReqAmount { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
        public uint StartEvent { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
        public uint StartAssetID { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
        public uint FailEvent { get; set; }

        [DbcColumn(9, Enums.DbcColumnDataType.UInt32)]
        public uint FailAssetID { get; set; }

        [DbcColumn(10, Enums.DbcColumnDataType.Loc)]
        public string? Description { get; set; }

        [DbcColumn(11, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }

        [DbcColumn(12, Enums.DbcColumnDataType.UInt32)]
        public uint TimerStartEvent { get; set; }

        [DbcColumn(13, Enums.DbcColumnDataType.UInt32)]
        public uint TimerAssetID { get; set; }

        [DbcColumn(14, Enums.DbcColumnDataType.UInt32)]
        public uint TimerTime { get; set; }

        [DbcColumn(15, Enums.DbcColumnDataType.UInt32)]
        public uint OrderInUI { get; set; }
    }
}
