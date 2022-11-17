using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("ChrClasses.dbc")]
    public class ChrClasses : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.UInt32)]
        public uint Unknown { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint PowerType { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.StringRef)]
        public string? PetNameToken { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Loc)]
        public string? Name { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.Loc)]
        public string? NameFemale { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.Loc)]
        public string? NameMale { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.StringRef)]
        public string? FileName { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
        public uint SpellClassSet { get; set; }

        [DbcColumn(9, Enums.DbcColumnDataType.UInt32)]
        public uint Flags { get; set; }

        [DbcColumn(10, Enums.DbcColumnDataType.UInt32)]
        public uint Camera { get; set; }

        [DbcColumn(11, Enums.DbcColumnDataType.UInt32)]
        public uint RequiredExpansion { get; set; }
    }
}
