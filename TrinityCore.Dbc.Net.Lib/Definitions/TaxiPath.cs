using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("TaxiPath.dbc")]
    public class TaxiPath : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int FromTaxiNode { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int ToTaxiNode { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Cost { get; set; }

        public TaxiNodes? GetFromTaxiNodeTaxiNodes()
        {
               return DbcDirectory.Open<TaxiNodes>()?.Where(c => c.Id == this.FromTaxiNode).FirstOrDefault();
        }

        public TaxiNodes? GetToTaxiNodeTaxiNodes()
        {
               return DbcDirectory.Open<TaxiNodes>()?.Where(c => c.Id == this.ToTaxiNode).FirstOrDefault();
        }

     }
}
