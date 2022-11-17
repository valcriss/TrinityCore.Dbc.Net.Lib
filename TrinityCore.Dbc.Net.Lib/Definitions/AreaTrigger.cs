using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AreaTrigger.dbc")]
    public class AreaTrigger : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }
        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint MapId { get; set; }
        [DbcColumn(2, Enums.DbcColumnDataType.Float)]
        public float X { get; set; }
        [DbcColumn(3, Enums.DbcColumnDataType.Float)]
        public float Y { get; set; }
        [DbcColumn(4, Enums.DbcColumnDataType.Float)]
        public float Z { get; set; }
        [DbcColumn(5, Enums.DbcColumnDataType.Float)]
        public float Radius { get; set; }
        [DbcColumn(6, Enums.DbcColumnDataType.Float)]
        public float BoxLength { get; set; }
        [DbcColumn(7, Enums.DbcColumnDataType.Float)]
        public float BoxWidth { get; set; }
        [DbcColumn(8, Enums.DbcColumnDataType.Float)]
        public float BoxHeight { get; set; }
        [DbcColumn(9, Enums.DbcColumnDataType.Float)]
        public float BoxOrientation { get; set; }
    }
}
