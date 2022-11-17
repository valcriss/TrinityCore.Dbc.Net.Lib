using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
   [DbcFile("CreatureDisplayInfo.dbc")]
   public class CreatureDisplayInfo : DbcFile
    {
      [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
      public uint Id { get; set; }

      [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
      public uint ModelID { get; set; }

      [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
      public uint SoundID { get; set; }

      [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
      public uint ExtendedDisplayInfoID { get; set; }

      [DbcColumn(4, Enums.DbcColumnDataType.Float)]
      public float CreatureModelScale { get; set; }

      [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
      public uint CreatureModelAlpha { get; set; }

      [DbcColumn(6, Enums.DbcColumnDataType.ArrayOfStringRef, 3)]
      public string[]? TextureVariation { get; set; }

      [DbcColumn(7, Enums.DbcColumnDataType.StringRef)]
      public string? PortraitTexture { get; set; }

      [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
      public uint SizeClass { get; set; }

      [DbcColumn(9, Enums.DbcColumnDataType.UInt32)]
      public uint BloodID { get; set; }

      [DbcColumn(10, Enums.DbcColumnDataType.UInt32)]
      public uint NPCSoundID { get; set; }

      [DbcColumn(11, Enums.DbcColumnDataType.UInt32)]
      public uint ParticleColorID { get; set; }

      [DbcColumn(12, Enums.DbcColumnDataType.UInt32)]
      public uint CreatureGeosetData { get; set; }

      [DbcColumn(13, Enums.DbcColumnDataType.UInt32)]
      public uint ObjectEffectPackageID { get; set; }

    }
}
