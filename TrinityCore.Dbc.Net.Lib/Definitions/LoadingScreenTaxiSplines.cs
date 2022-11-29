using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("LoadingScreenTaxiSplines.dbc")]
    public class LoadingScreenTaxiSplines : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int PathId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfFloat, 8)]
        public float[]? Locx { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.ArrayOfFloat, 8)]
        public float[]? Locy { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int LegIndex { get; set; }

        public TaxiPath? GetPathIdTaxiPath()
        {
               return DbcDirectory.Open<TaxiPath>()?.Where(c => c.Id == this.PathId).FirstOrDefault();
        }

     }
}
