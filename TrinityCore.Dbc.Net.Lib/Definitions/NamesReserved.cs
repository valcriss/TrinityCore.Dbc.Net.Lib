using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("NamesReserved.dbc")]
    public class NamesReserved : DbcFile
    {
        [DbcColumn(0,Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1,Enums.DbcColumnDataType.StringRef)]
        public string? Pattern { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint LanguageID { get; set; }
    }
}
