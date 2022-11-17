using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AreaGroup.dbc")]
    public class AreaGroup : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 6)]
        public uint[]? Areas { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint LinkedAreaGroup { get; set; }        
    }
}
