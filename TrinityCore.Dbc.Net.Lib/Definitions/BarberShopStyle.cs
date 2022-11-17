using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("BarberShopStyle.dbc")]
    public class BarberShopStyle : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Type { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Loc)]
        public string? Name { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? Description { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Float)]
        public float CostModifier { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
        public uint Race { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
        public uint Gender { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
        public uint Data { get; set; }
    }
}
