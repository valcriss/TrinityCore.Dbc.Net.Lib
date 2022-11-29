using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("GlyphProperties.dbc")]
    public class GlyphProperties : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int SpellId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int GlyphSlotFlags { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int SpellIconId { get; set; }

        public Spell? GetSpellIdSpell()
        {
               return DbcDirectory.Open<Spell>()?.Where(c => c.Id == this.SpellId).FirstOrDefault();
        }

        public SpellIcon? GetSpellIconIdSpellIcon()
        {
               return DbcDirectory.Open<SpellIcon>()?.Where(c => c.Id == this.SpellIconId).FirstOrDefault();
        }

     }
}
