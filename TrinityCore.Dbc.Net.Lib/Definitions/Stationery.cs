using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Stationery.dbc")]
    public class Stationery : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int ItemId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.StringRef)]
        public string? Texture { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

        public Item? GetItemIdItem()
        {
               return DbcDirectory.Open<Item>()?.Where(c => c.Id == this.ItemId).FirstOrDefault();
        }

     }
}
