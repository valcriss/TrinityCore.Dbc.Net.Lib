using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("PetPersonality.dbc")]
    public class PetPersonality : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfUint32, 3)]
        public int[]? HappinessThreshold { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfFloat, 3)]
        public float[]? HappinessDamage { get; set; }

     }
}
