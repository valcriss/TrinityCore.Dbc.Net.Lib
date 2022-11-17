using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
   [DbcFile("CinematicCamera.dbc")]
   public class CinematicCamera : DbcFile
    {
      [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
      public uint Id { get; set; }

      [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
      public string? Model { get; set; }

      [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
      public uint SoundID { get; set; }

      [DbcColumn(3, Enums.DbcColumnDataType.Float)]
      public float X { get; set; }

      [DbcColumn(4, Enums.DbcColumnDataType.Float)]
      public float Y { get; set; }

      [DbcColumn(5, Enums.DbcColumnDataType.Float)]
      public float Z { get; set; }

      [DbcColumn(6, Enums.DbcColumnDataType.Float)]
      public float Facing { get; set; }

    }
}
