using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
   [DbcFile("AreaPOI.dbc")]
   public class AreaPOI : DbcFile
    {
      [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
      public uint Id { get; set; }

      [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
      public uint Importance { get; set; }

      [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 9)]
      public uint[]? Icon { get; set; }

      [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
      public uint FactionID { get; set; }

      [DbcColumn(4, Enums.DbcColumnDataType.Float)]
      public float X { get; set; }

      [DbcColumn(5, Enums.DbcColumnDataType.Float)]
      public float Y { get; set; }

      [DbcColumn(6, Enums.DbcColumnDataType.Float)]
      public float Z { get; set; }

      [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
      public uint ContinentID { get; set; }

      [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
      public uint Flags { get; set; }

      [DbcColumn(9, Enums.DbcColumnDataType.UInt32)]
      public uint AreaID { get; set; }

      [DbcColumn(10, Enums.DbcColumnDataType.Loc)]
      public string? Name { get; set; }

      [DbcColumn(11, Enums.DbcColumnDataType.Loc)]
      public string? Description { get; set; }

      [DbcColumn(12, Enums.DbcColumnDataType.UInt32)]
      public uint WorldStateID { get; set; }

      [DbcColumn(13, Enums.DbcColumnDataType.UInt32)]
      public uint WorldMapLink { get; set; }

    }
}
