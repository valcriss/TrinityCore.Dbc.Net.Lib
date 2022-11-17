using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ChrRaces.dbc")]
    public class ChrRaces : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint FactionID { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.UInt32)]
        public uint ExplorationSoundId { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.UInt32)]
        public uint MaleModel { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
        public uint FemaleModel { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.StringRef)]
        public string? ClientPrefix { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
        public uint BaseLanguage { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
        public uint CreatureType { get; set; }

        [DbcColumn(9, Enums.DbcColumnDataType.UInt32)]
        public uint ResSicknessSpellID { get; set; }

        [DbcColumn(10, Enums.DbcColumnDataType.UInt32)]
        public uint SplashSoundID { get; set; }

        [DbcColumn(11, Enums.DbcColumnDataType.StringRef)]
        public string? ClientFileString { get; set; }

        [DbcColumn(12, Enums.DbcColumnDataType.UInt32)]
        public uint CinematicSequenceID { get; set; }

        [DbcColumn(13, Enums.DbcColumnDataType.UInt32)]
        public uint Alliance { get; set; }

        [DbcColumn(14, Enums.DbcColumnDataType.Loc)]
        public string? RaceNameNeutral { get; set; }

        [DbcColumn(15, Enums.DbcColumnDataType.Loc)]
        public string? RaceNameFemale { get; set; }

        [DbcColumn(16, Enums.DbcColumnDataType.Loc)]
        public string? RaceNameMale { get; set; }

        [DbcColumn(17, Enums.DbcColumnDataType.ArrayOfStringRef, 2)]
        public string[]? FacialHairCustomization { get; set; }

        [DbcColumn(18, Enums.DbcColumnDataType.StringRef)]
        public string? HairCustomization { get; set; }

        [DbcColumn(19, Enums.DbcColumnDataType.UInt32)]
        public uint RequiredExpansion { get; set; }
    }
}
