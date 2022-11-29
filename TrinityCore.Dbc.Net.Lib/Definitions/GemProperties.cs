using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("GemProperties.dbc")]
    public class GemProperties : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int EnchantId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int MaxcountInv { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int MaxcountItem { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int Type { get; set; }

        public SpellItemEnchantment? GetEnchantIdSpellItemEnchantment()
        {
               return DbcDirectory.Open<SpellItemEnchantment>()?.Where(c => c.Id == this.EnchantId).FirstOrDefault();
        }

     }
}
