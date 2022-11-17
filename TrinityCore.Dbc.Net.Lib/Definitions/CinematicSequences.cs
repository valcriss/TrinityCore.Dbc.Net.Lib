using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
   [DbcFile("CinematicSequences.dbc")]
   public class CinematicSequences : DbcFile
    {
      [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
      public uint Id { get; set; }

      [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
      public uint SoundID { get; set; }

      [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 8)]
      public uint[]? Camera { get; set; }

    }
}
