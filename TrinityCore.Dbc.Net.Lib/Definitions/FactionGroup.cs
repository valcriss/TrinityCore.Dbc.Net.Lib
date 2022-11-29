using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("FactionGroup.dbc")]
    public class FactionGroup : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int MaskId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.StringRef)]
        public string? InternalName { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

     }
}
