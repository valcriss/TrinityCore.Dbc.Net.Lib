using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CharBaseInfo.dbc")]
    public class CharBaseInfo : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt8)]
        public sbyte RaceId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt8)]
        public sbyte ClassId { get; set; }
    }
}
