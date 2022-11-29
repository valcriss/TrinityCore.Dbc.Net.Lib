using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("EnvironmentalDamage.dbc")]
    public class EnvironmentalDamage : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int EnumId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int VisualkitId { get; set; }

        public SpellVisualKit? GetVisualkitIdSpellVisualKit()
        {
               return DbcDirectory.Open<SpellVisualKit>()?.Where(c => c.Id == this.VisualkitId).FirstOrDefault();
        }

     }
}
