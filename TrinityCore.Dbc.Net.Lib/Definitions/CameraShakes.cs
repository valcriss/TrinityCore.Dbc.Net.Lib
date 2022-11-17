using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("CameraShakes.dbc")]
    public class CameraShakes : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint ShakeType { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint Direction { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Float)]
        public float Amplitude { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Float)]
        public float Frequency { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Float)]
        public float Duration { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.Float)]
        public float Phase { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.Float)]
        public float Coefficient { get; set; }

    }
}
