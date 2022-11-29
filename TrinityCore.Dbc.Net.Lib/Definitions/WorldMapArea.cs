using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("WorldMapArea.dbc")]
    public class WorldMapArea : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int MapId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int AreaId { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.StringRef)]
        public string? AreaName { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Float)]
        public float LocLeft { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Float)]
        public float LocRight { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.Float)]
        public float LocTop { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.Float)]
        public float LocBottom { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.Int32)]
        public int DisplayMapId { get; set; }

        [DbcColumn(9, Enums.DbcColumnDataType.Int32)]
        public int DefaultDungeonFloor { get; set; }

        [DbcColumn(10, Enums.DbcColumnDataType.Int32)]
        public int ParentWorldMapId { get; set; }

        public Map? GetMapIdMap()
        {
               return DbcDirectory.Open<Map>()?.Where(c => c.Id == this.MapId).FirstOrDefault();
        }

        public AreaTable? GetAreaIdAreaTable()
        {
               return DbcDirectory.Open<AreaTable>()?.Where(c => c.Id == this.AreaId).FirstOrDefault();
        }

        public Map? GetDisplayMapIdMap()
        {
               return DbcDirectory.Open<Map>()?.Where(c => c.Id == this.DisplayMapId).FirstOrDefault();
        }

        public WorldMapArea? GetParentWorldMapIdWorldMapArea()
        {
               return DbcDirectory.Open<WorldMapArea>()?.Where(c => c.Id == this.ParentWorldMapId).FirstOrDefault();
        }

     }
}
