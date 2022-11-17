using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CharacterFacialHairStyles.dbc")]
    public class CharacterFacialHairStyles : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint ChrRace { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Gender { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint Variation { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint Geoset_1 { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint Geoset_2 { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
        public uint Geoset_3 { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
        public uint Geoset_4 { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
        public uint Geoset_5 { get; set; }
    }
}
