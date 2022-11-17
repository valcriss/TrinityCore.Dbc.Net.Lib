using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CharVariations.dbc")]
    public class CharVariations : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint RaceId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint SexId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32,4)]
        public uint[]? TextureHoldLayers { get; set; }
    }
}
