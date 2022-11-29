using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AreaGroup.dbc")]
    public class AreaGroup : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 6)]
        public int[]? AreaId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int NextAreaId { get; set; }

        public AreaTable[]? GetAreaIdAreaTables()
        {
               return DbcDirectory.Open<AreaTable>()?.Where(c => this.AreaId != null && this.AreaId.Contains(c.Id)).ToArray();
        }

        public AreaGroup? GetNextAreaIdAreaGroup()
        {
               return DbcDirectory.Open<AreaGroup>()?.Where(c => c.Id == this.NextAreaId).FirstOrDefault();
        }

     }
}
