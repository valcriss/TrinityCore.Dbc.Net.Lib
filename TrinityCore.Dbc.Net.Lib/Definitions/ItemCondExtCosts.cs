using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ItemCondExtCosts.dbc")]
    public class ItemCondExtCosts : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int CondExtendedCost { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int ItemExtendedCostEntry { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int ArenaSeason { get; set; }

        public ItemExtendedCost? GetItemExtendedCostEntryItemExtendedCost()
        {
               return DbcDirectory.Open<ItemExtendedCost>()?.Where(c => c.Id == this.ItemExtendedCostEntry).FirstOrDefault();
        }

     }
}
