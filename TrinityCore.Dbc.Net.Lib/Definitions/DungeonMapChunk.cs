using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("DungeonMapChunk.dbc")]
    public class DungeonMapChunk : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int MapId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int WMOGroupId { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int DungeonMapId { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Float)]
        public float MinZ { get; set; }

        public Map? GetMapIdMap()
        {
               return DbcDirectory.Open<Map>()?.Where(c => c.Id == this.MapId).FirstOrDefault();
        }

        public WMOAreaTable? GetWMOGroupIdWMOAreaTable()
        {
               return DbcDirectory.Open<WMOAreaTable>()?.Where(c => c.WMOGroupId == this.WMOGroupId).FirstOrDefault();
        }

        public DungeonMap? GetDungeonMapIdDungeonMap()
        {
               return DbcDirectory.Open<DungeonMap>()?.Where(c => c.Id == this.DungeonMapId).FirstOrDefault();
        }

     }
}
