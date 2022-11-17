using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("BattlemasterList.dbc")]
    public class BattlemasterList : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.UInt32)]
        public uint Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.ArrayOfUint32, 8)]
        public uint[]? Maps { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.UInt32)]
        public uint InstanceType { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Bool)]
        public bool GroupsAllowed { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Loc)]
        public string? Name { get; set; }

        [DbcColumn(5, Enums.DbcColumnDataType.UInt32)]
        public uint MaxGroupSize { get; set; }

        [DbcColumn(6, Enums.DbcColumnDataType.UInt32)]
        public uint HolidayWorldState { get; set; }

        [DbcColumn(7, Enums.DbcColumnDataType.UInt32)]
        public uint MinLevel { get; set; }

        [DbcColumn(8, Enums.DbcColumnDataType.UInt32)]
        public uint MaxLevel { get; set; }
    }
}
