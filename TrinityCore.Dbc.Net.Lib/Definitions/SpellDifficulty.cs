using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SpellDifficulty.dbc")]
    public class SpellDifficulty : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 4)]
        public int[]? DifficultySpellId { get; set; }

        public Spell[]? GetDifficultySpellIdSpells()
        {
               return DbcDirectory.Open<Spell>()?.Where(c => this.DifficultySpellId != null && this.DifficultySpellId.Contains(c.Id)).ToArray();
        }

     }
}
