using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Achievement_Category.dbc")]
    public class AchievementCategory : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Parent { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Loc)]
        public string? NameLang { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int UiOrder { get; set; }

        public AchievementCategory? GetParentAchievementCategory()
        {
               return DbcDirectory.Open<AchievementCategory>()?.Where(c => c.Id == this.Parent).FirstOrDefault();
        }

     }
}
