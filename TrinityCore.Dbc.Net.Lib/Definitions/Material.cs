using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Material.dbc")]
    public class Material : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int FoleySoundId { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int SheatheSoundId { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int UnsheatheSoundId { get; set; }

     }
}
