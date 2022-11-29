using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("MovieFileData.dbc")]
    public class MovieFileData : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int FileDataId { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Resolution { get; set; }

        public FileData? GetFileDataIdFileData()
        {
               return DbcDirectory.Open<FileData>()?.Where(c => c.Id == this.FileDataId).FirstOrDefault();
        }

     }
}
