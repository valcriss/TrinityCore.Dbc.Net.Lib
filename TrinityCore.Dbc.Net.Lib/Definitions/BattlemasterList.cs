using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("BattlemasterList.dbc")]
    public class BattlemasterList : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 8)]
        public int[]? MapId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int InstanceType { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int GroupsAllowed { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Int32)]
        public int MaxGroupSize { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.Int32)]
        public int HolidayWorldState { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.Int32)]
        public int MinLevel { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.Int32)]
        public int MaxLevel { get; set; }

        public Map[]? GetMapIdMaps()
        {
               return DbcDirectory.Open<Map>()?.Where(c => this.MapId != null && this.MapId.Contains(c.Id)).ToArray();
        }

     }
}
