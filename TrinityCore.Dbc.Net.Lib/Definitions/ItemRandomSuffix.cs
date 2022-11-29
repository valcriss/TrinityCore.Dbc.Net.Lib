using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ItemRandomSuffix.dbc")]
    public class ItemRandomSuffix : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.StringRef)]
        public string? InternalName { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfUint32, 5)]
        public int[]? Enchantment { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.ArrayOfUint32, 5)]
        public int[]? AllocationPct { get; set; }

        public SpellItemEnchantment[]? GetEnchantmentSpellItemEnchantments()
        {
               return DbcDirectory.Open<SpellItemEnchantment>()?.Where(c => this.Enchantment != null && this.Enchantment.Contains(c.Id)).ToArray();
        }

     }
}
