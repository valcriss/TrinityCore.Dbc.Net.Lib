using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AreaTable.dbc")]
    public class AreaTable : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint MapId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint ParentArea { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint AreaBit { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
        public uint SoundProviderPrefferences { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
        public uint UnderwaterSoundProviderPrefferences { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
        public uint SoundAmbience { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
        public uint ZoneMusic { get; set; }

        [DbcColumn(9, Enums.DbcColumnDataType.UInt32)]
        public uint ZoneIntroMusicTable { get; set; }

        [DbcColumn(10, Enums.DbcColumnDataType.UInt32)]
        public uint ExplorationLevel { get; set; }

        [DbcColumn(11, Enums.DbcColumnDataType.Loc)]
        public string? Name { get; set; }

        [DbcColumn(12, Enums.DbcColumnDataType.UInt32)]
        public uint FactionGroup { get; set; }

        [DbcColumn(13, Enums.DbcColumnDataType.ArrayOfUint32, 4)]
        public uint[]? LiquidType { get; set; }

        [DbcColumn(14, Enums.DbcColumnDataType.Float)]
        public float MinElevation { get; set; }

        [DbcColumn(15, Enums.DbcColumnDataType.Float)]
        public float AmbientMultiplier { get; set; }

        [DbcColumn(16, Enums.DbcColumnDataType.UInt32)]
        public uint Light { get; set; }
    }
}
