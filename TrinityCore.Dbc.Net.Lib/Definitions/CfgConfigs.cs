using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Cfg_Configs.dbc")]
    public class CfgConfigs : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint RealmType { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint PlayerKillingAllowed { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint Roleplaying { get; set; }
    }
}
