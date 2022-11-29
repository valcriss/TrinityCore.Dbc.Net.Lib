using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("BarberShopStyle.dbc")]
    public class BarberShopStyle : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Type { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Loc)]
        public string? DisplayNameLang { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Loc)]
        public string? Description { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Float)]
        public float CostModifier { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Int32)]
        public int Race { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.Int32)]
        public int Sex { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.Int32)]
        public int Data { get; set; }

        public ChrRaces? GetRaceChrRaces()
        {
               return DbcDirectory.Open<ChrRaces>()?.Where(c => c.Id == this.Race).FirstOrDefault();
        }

     }
}
