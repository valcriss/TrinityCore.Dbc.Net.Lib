using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AuctionHouse.dbc")]
    public class AuctionHouse : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Faction { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint DepositRate { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint AuctionCut { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Loc)]
        public string Name { get; set; }
    }
}
