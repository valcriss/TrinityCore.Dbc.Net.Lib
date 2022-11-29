using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("SpellVisualPrecastTransitions.dbc")]
    public class SpellVisualPrecastTransitions : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.StringRef)]
        public string? PrecastLoadAnimName { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.StringRef)]
        public string? PrecastHoldAnimName { get; set; }

     }
}
