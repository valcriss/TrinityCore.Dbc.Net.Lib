using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CharStartOutfit.dbc")]
    public class CharStartOutfit : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Byte)]
        public byte Race { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Byte)]
        public byte Class { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Byte)]
        public byte Gender { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Byte)]
        public byte OutfitId { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.ArrayOfUint32, 24)]
        public uint[]? Items { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.ArrayOfUint32, 24)]
        public uint[]? DisplayInfo { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.ArrayOfUint32, 24)]
        public uint[]? InventoryType { get; set; }
    }
}
