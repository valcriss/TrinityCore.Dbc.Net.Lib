using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ItemPurchaseGroup.dbc")]
    public class ItemPurchaseGroup : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 8)]
        public int[]? ItemId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        public Item[]? GetItemIdItems()
        {
               return DbcDirectory.Open<Item>()?.Where(c => this.ItemId != null && this.ItemId.Contains(c.Id)).ToArray();
        }

     }
}
