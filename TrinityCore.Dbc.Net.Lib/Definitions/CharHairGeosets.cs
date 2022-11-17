using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CharHairGeosets.dbc")]
    public class CharHairGeosets : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Race { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Bool)]
        public bool Gender { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint HairType { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint Geoset { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Bool)]
        public bool Bald { get; set; }
    }
}
