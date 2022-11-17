using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
   [DbcFile("CreatureFamily.dbc")]
   public class CreatureFamily : DbcFile
    {
      [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
      public uint Id { get; set; }

      [DbcColumn(1, Enums.DbcColumnDataType.Float)]
      public float MinScale { get; set; }

      [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
      public uint MinScaleLevel { get; set; }

      [DbcColumn(3, Enums.DbcColumnDataType.Float)]
      public float MaxScale { get; set; }

      [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
      public uint MaxScaleLevel { get; set; }

      [DbcColumn(5, Enums.DbcColumnDataType.ArrayOfUint32, 2)]
      public uint[]? SkillLine { get; set; }

      [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
      public uint PetFoodMask { get; set; }

      [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
      public uint PetTalentType { get; set; }

      [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
      public uint CategoryEnumID { get; set; }

      [DbcColumn(9, Enums.DbcColumnDataType.Loc)]
      public string? Name { get; set; }

      [DbcColumn(10, Enums.DbcColumnDataType.StringRef)]
      public string? IconFile { get; set; }

    }
}
