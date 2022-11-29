using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("MovieVariation.dbc")]
    public class MovieVariation : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int MovieId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int FileDataId { get; set; }

        public Movie? GetMovieIdMovie()
        {
               return DbcDirectory.Open<Movie>()?.Where(c => c.Id == this.MovieId).FirstOrDefault();
        }

        public FileData? GetFileDataIdFileData()
        {
               return DbcDirectory.Open<FileData>()?.Where(c => c.Id == this.FileDataId).FirstOrDefault();
        }

     }
}
