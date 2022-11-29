using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("Cfg_Configs.dbc")]
    public class CfgConfigs : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int RealmType { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int PlayerKillingAllowed { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int Roleplaying { get; set; }

     }
}
