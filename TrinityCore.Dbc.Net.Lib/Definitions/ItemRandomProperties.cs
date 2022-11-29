using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ItemRandomProperties.dbc")]
    public class ItemRandomProperties : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Name { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 5)]
        public int[]? Enchantment { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        public SpellItemEnchantment[]? GetEnchantmentSpellItemEnchantments()
        {
               return DbcDirectory.Open<SpellItemEnchantment>()?.Where(c => this.Enchantment != null && this.Enchantment.Contains(c.Id)).ToArray();
        }

     }
}
