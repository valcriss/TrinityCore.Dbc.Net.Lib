using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CharSections.dbc")]
    public class CharSections : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint RaceId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint Gender { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint GeneralType { get; set; }       

        [DbcColumn(4, Enums.DbcColumnDataType.StringRef)]
        public string? Texture1 { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.StringRef)]
        public string? Texture2 { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.StringRef)]
        public string? Texture3 { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
        public uint Type { get; set; }

        [DbcColumn(9, Enums.DbcColumnDataType.UInt32)]
        public uint Variation { get; set; }


    }
}
