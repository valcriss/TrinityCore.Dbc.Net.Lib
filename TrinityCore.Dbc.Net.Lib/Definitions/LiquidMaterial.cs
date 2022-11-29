using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("LiquidMaterial.dbc")]
    public class LiquidMaterial : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int LVF { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

     }
}
