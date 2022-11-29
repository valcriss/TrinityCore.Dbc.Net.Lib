using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("TotemCategory.dbc")]
    public class TotemCategory : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int TotemCategoryType { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int TotemCategoryMask { get; set; }

     }
}
