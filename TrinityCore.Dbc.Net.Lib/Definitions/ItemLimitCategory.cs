using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ItemLimitCategory.dbc")]
    public class ItemLimitCategory : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Quantity { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

     }
}
