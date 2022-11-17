using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CharHairTextures.dbc")]
    public class CharHairTextures : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Race { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Bool)]
        public bool Gender { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Bool)]
        public bool Unknown1 { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint Unknown2 { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
        public uint Unknown3 { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
        public uint Unknown4 { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
        public uint Unknown5 { get; set; }
    }
}
