using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
   [DbcFile("CreatureDisplayInfoExtra.dbc")]
   public class CreatureDisplayInfoExtra : DbcFile
    {
      [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
      public uint Id { get; set; }

      [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
      public uint DisplayRaceID { get; set; }

      [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
      public uint DisplaySexID { get; set; }

      [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
      public uint SkinID { get; set; }

      [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
      public uint FaceID { get; set; }

      [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
      public uint HairStyleID { get; set; }

      [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
      public uint HairColorID { get; set; }

      [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
      public uint FacialHairID { get; set; }

      [DbcColumn(8, Enums.DbcColumnDataType.ArrayOfUint32, 11)]
      public uint[]? NPCItemDisplay { get; set; }

      [DbcColumn(9, Enums.DbcColumnDataType.UInt32)]
      public uint Flags { get; set; }

      [DbcColumn(10, Enums.DbcColumnDataType.StringRef)]
      public string? BakeName { get; set; }

    }
}
