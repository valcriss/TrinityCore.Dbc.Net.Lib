using TrinityCore.Dbc.Net.Lib.Enums;

namespace TrinityCore.Dbc.Net.Lib.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class DbcColumnAttribute : Attribute
    {
        public int ArrayCount { get; set; }
        public int Column { get; set; }
        public DbcColumnDataType DataType { get; set; }

        public DbcColumnAttribute(int column, DbcColumnDataType dataType, int arrayCount = 0)
        {
            Column = column;
            DataType = dataType;
            ArrayCount = arrayCount;
        }
    }
}