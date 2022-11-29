using TrinityCore.Dbc.Net.Lib.Attributes;

namespace TrinityCore.Dbc.Net.Lib.Definitions
{
    [DbcFile("AttackAnimKits.dbc")]
    public class AttackAnimKits : DbcFile
    {
        [DbcColumn(0, Enums.DbcColumnDataType.Int32)]
        public int Id { get; set; }

        [DbcColumn(1, Enums.DbcColumnDataType.Int32)]
        public int ItemSubclassId { get; set; }

        [DbcColumn(2, Enums.DbcColumnDataType.Int32)]
        public int AnimTypeId { get; set; }

        [DbcColumn(3, Enums.DbcColumnDataType.Int32)]
        public int AnimFrequency { get; set; }

        [DbcColumn(4, Enums.DbcColumnDataType.Int32)]
        public int WhichHand { get; set; }

        public AttackAnimTypes? GetAnimTypeIdAttackAnimTypes()
        {
               return DbcDirectory.Open<AttackAnimTypes>()?.Where(c => c.AnimId == this.AnimTypeId).FirstOrDefault();
        }

     }
}
