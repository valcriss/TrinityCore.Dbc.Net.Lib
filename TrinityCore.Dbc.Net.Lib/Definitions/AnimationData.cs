using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AnimationData.dbc")]
    public class AnimationData : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? Name { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Weaponflags { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Bodyflags { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int Flags { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Int32)]
        public int Fallback { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.Int32)]
        public int BehaviorId { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.Int32)]
        public int BehaviorTier { get; set; }

        public AnimationData? GetFallbackAnimationData()
        {
               return DbcDirectory.Open<AnimationData>()?.Where(c => c.Id == this.Fallback).FirstOrDefault();
        }

        public AnimationData? GetBehaviorIdAnimationData()
        {
               return DbcDirectory.Open<AnimationData>()?.Where(c => c.Id == this.BehaviorId).FirstOrDefault();
        }

     }
}
