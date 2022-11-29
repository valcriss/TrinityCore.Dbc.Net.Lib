using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("OverrideSpellData.dbc")]
    public class OverrideSpellData : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 10)]
        public int[]? Spells { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

        public Spell[]? GetSpellsSpells()
        {
               return DbcDirectory.Open<Spell>()?.Where(c => this.Spells != null && this.Spells.Contains(c.Id)).ToArray();
        }

     }
}
