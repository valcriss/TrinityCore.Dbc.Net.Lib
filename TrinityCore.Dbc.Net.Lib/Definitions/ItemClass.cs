using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ItemClass.dbc")]
    public class ItemClass : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int ClassId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int SubclassMapId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? ClassNameLang { get; set; }

     }
}
