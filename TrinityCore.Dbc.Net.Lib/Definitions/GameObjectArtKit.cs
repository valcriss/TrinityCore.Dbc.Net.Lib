using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("GameObjectArtKit.dbc")]
    public class GameObjectArtKit : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfStringRef, 3)]
        public string[]? TextureVariation { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.ArrayOfStringRef, 4)]
        public string[]? AttachModel { get; set; }

     }
}
