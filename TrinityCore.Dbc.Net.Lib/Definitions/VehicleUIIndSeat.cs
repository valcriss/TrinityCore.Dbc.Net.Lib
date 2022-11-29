using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("VehicleUIIndSeat.dbc")]
    public class VehicleUIIndSeat : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int VehicleUIIndicatorId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int VirtualSeatIndex { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Float)]
        public float XPos { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Float)]
        public float YPos { get; set; }

        public VehicleUIIndicator? GetVehicleUIIndicatorIdVehicleUIIndicator()
        {
               return DbcDirectory.Open<VehicleUIIndicator>()?.Where(c => c.Id == this.VehicleUIIndicatorId).FirstOrDefault();
        }

     }
}
