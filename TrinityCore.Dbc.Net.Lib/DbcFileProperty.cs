using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TrinityCore.Dbc.Net.Lib.Enums;

namespace TrinityCore.Dbc.Net.Lib
{
    internal class DbcFileProperty
    {
        internal PropertyInfo Property { get; set; }
        internal int Column { get; set; }
        internal DbcColumnDataType DataType { get; set; }

        internal int ArrayCount { get; set; }

        public DbcFileProperty(PropertyInfo property, int column, DbcColumnDataType dataType, int arrayCount)
        {
            Property = property;
            Column = column;
            DataType = dataType;
            ArrayCount = arrayCount;
        }

        internal object? ReadValue(ref int index, byte[] content, Dictionary<uint, string> stringBlocks)
        {
            switch (DataType)
            {
                case DbcColumnDataType.Bool:
                    return ReadBool(ref index, content);
                case DbcColumnDataType.Byte:
                    return ReadByte(ref index, content);
                case DbcColumnDataType.UInt8:
                    return ReadUInt8(ref index, content);
                case DbcColumnDataType.UInt32:
                    return ReadUint(ref index, content);
                case DbcColumnDataType.Int32:
                    return ReadInt(ref index, content);
                case DbcColumnDataType.ArrayOfUint32:
                    return ReadUintArray(ref index, content);
                case DbcColumnDataType.ArrayOfStringRef:
                    return ReadArrayOfStringRef(ref index, content, stringBlocks);
                case DbcColumnDataType.Float:
                    return ReadFloat(ref index, content);
                case DbcColumnDataType.StringRef:
                    uint stringIndex = ReadUint(ref index, content);
                    if (!stringBlocks.ContainsKey(stringIndex)) return null;
                    return stringBlocks[stringIndex];
                case DbcColumnDataType.Loc:
                    uint stringLocIndex = ReadLoc(ref index, content);
                    if (!stringBlocks.ContainsKey(stringLocIndex)) return null;
                    return stringBlocks[stringLocIndex];
                default:
                    return null;
            }
        }

        private bool ReadBool(ref int index, byte[] content)
        {
            byte result = content[index];
            index += 1;
            return result == 0x01;
        }

        private uint[] ReadUintArray(ref int index, byte[] content)
        {
            uint[] result = new uint[ArrayCount];
            for (int i = 0; i < ArrayCount; i++)
            {
                uint value = BitConverter.ToUInt32(content, index);
                index += 4;
                result[i] = value;
            }

            return result;
        }

        private string?[] ReadArrayOfStringRef(ref int index, byte[] content, Dictionary<uint, string> stringBlocks)
        {
            string?[]? result = new string[ArrayCount];
            for (int i = 0; i < ArrayCount; i++)
            {
                uint value = BitConverter.ToUInt32(content, index);
                index += 4;
                result[i] = stringBlocks.ContainsKey(value) ? stringBlocks[value] : null;
            }

            return result;
        }

        private float ReadFloat(ref int index, byte[] content)
        {
            float value = BitConverter.ToSingle(content, index);
            index += 4;
            return value;
        }

        private byte ReadByte(ref int index, byte[] content)
        {
            byte value = (byte)content[index];
            index += 1;
            return value;
        }

        private sbyte ReadUInt8(ref int index, byte[] content)
        {
            sbyte value = (sbyte)content[index];
            index += 1;
            return value;
        }

        private uint ReadUint(ref int index, byte[] content)
        {
            uint value = BitConverter.ToUInt32(content, index);
            index += 4;
            return value;
        }

        private int ReadInt(ref int index, byte[] content)
        {
            int value = BitConverter.ToInt32(content, index);
            index += 4;
            return value;
        }

        private uint ReadLoc(ref int index, byte[] content)
        {
            Dictionary<DbcLocale, uint> locales = new Dictionary<DbcLocale, uint>();
            foreach (DbcLocale locale in (DbcLocale[])Enum.GetValues(typeof(DbcLocale)))
            {
                uint value = BitConverter.ToUInt32(content, index);
                index += 4;
                locales.Add(locale, value);
            }

            return locales[DbcDirectory.GetLocale()];
        }
    }
}
