using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SoundFilterElem.dbc")]
    public class SoundFilterElem : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int SoundFilterId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int OrderIndex { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int FilterType { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.ArrayOfFloat, 9)]
        public float[]? Params { get; set; }

        public SoundFilter? GetSoundFilterIdSoundFilter()
        {
               return DbcDirectory.Open<SoundFilter>()?.Where(c => c.Id == this.SoundFilterId).FirstOrDefault();
        }

     }
}
