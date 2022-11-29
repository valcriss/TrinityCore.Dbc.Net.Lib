using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ItemSubClassMask.dbc")]
    public class ItemSubClassMask : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int ClassId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Mask { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        public ItemClass? GetClassIdItemClass()
        {
               return DbcDirectory.Open<ItemClass>()?.Where(c => c.ClassId == this.ClassId).FirstOrDefault();
        }

     }
}
