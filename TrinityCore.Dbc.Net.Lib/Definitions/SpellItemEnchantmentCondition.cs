using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SpellItemEnchantmentCondition.dbc")]
    public class SpellItemEnchantmentCondition : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfBool, 5)]
        public bool[]? LtOperandType { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 5)]
        public int[]? LtOperand { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfBool, 5)]
        public bool[]? Operator { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.ArrayOfBool, 5)]
        public bool[]? RtOperandType { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.ArrayOfUint32, 5)]
        public int[]? RtOperand { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.ArrayOfBool, 5)]
        public bool[]? Logic { get; set; }

     }
}
