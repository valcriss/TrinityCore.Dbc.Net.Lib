using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SoundSamplePreferences.dbc")]
    public class SoundSamplePreferences : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int Field0603592001 { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int Field0603592002 { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int EAX2SampleRoom { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int Field0603592004 { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Int32)]
        public int Field0603592005 { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.Float)]
        public float Field0603592006 { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.Int32)]
        public int Field0603592007 { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.Float)]
        public float EAX2SampleOcclusionLFRatio { get; set; }

        [DbcColumn(9, Enums.DbcColumnDataType.Float)]
        public float EAX2SampleOcclusionRoomRatio { get; set; }

        [DbcColumn(10, Enums.DbcColumnDataType.Int32)]
        public int Field0603592010 { get; set; }

        [DbcColumn(11, Enums.DbcColumnDataType.Float)]
        public float EAX1EffectLevel { get; set; }

        [DbcColumn(12, Enums.DbcColumnDataType.Int32)]
        public int Field0603592012 { get; set; }

        [DbcColumn(13, Enums.DbcColumnDataType.Float)]
        public float Field0603592013 { get; set; }

        [DbcColumn(14, Enums.DbcColumnDataType.Float)]
        public float EAX3SampleExclusion { get; set; }

        [DbcColumn(15, Enums.DbcColumnDataType.Float)]
        public float Field0603592015 { get; set; }

        [DbcColumn(16, Enums.DbcColumnDataType.Int32)]
        public int Field0603592016 { get; set; }

     }
}
