using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CharTitles.dbc")]
    public class CharTitles : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Unknown { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Loc)]
        public string? Male { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? Female { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint TitleMaskID { get; set; }
    }
}
