using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ObjectEffectModifier.dbc")]
    public class ObjectEffectModifier : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int InputType { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int MapType { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int OutputType { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.ArrayOfFloat, 4)]
        public float[]? Param { get; set; }

     }
}
