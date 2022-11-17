using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Enums;
using TrinityCore.Dbc.Net.Lib.Extensions;

namespace TrinityCore.Dbc.Net.Lib
{
    public static class DbcDirectory
    {
        private static string? Directory { get; set; }
        private static Dictionary<string, object> Storage { get; set; }

        private static DbcLocale Locale { get; set; }

        static DbcDirectory()
        {
            Storage = new Dictionary<string, object>();
            Locale = DbcLocale.enUS;
        }

        public static void Initialize(string dbcDirectory, DbcLocale locale = DbcLocale.enUS)
        {
            if (!System.IO.Directory.Exists(dbcDirectory))
            {
                throw new DirectoryNotFoundException($"Unable to find directory [{dbcDirectory}]");
            }
            Locale = locale;
            Directory = dbcDirectory;
        }

        public static List<T> Open<T>() where T : DbcFile, new()
        {
            string key = typeof(T).Name;
            if (Storage.ContainsKey(key)) return (List<T>)Storage[key];
            List<T> items = OpenFile<T>();
            Storage.Add(key, items);
            return items;
        }

        private static List<T> OpenFile<T>() where T : DbcFile, new()
        {
            if (Directory == null)
            {
                throw new InvalidOperationException("You must call Initialize method before calling Open");
            }
            int propertyCount = typeof(T).GetDbcFileColumnCount();
            string? filename = typeof(T).GetDbcFilename();
            if (filename == null) throw new InvalidOperationException("Unable to retreive dbc filename from DbcFile class");
            string fullFilemane = Path.Combine(Directory, filename);
            if (!File.Exists(fullFilemane)) throw new FileNotFoundException($"Unable to find [{filename}] in directory [{Directory}]");

            byte[] content = File.ReadAllBytes(fullFilemane);
            DbcHeader? header = DbcHeader.Read(content);
            if (header == null) throw new InvalidDataException($"Unable to read dbc header from file [{filename}]");
            if (header.Magic != DbcHeader.DBC_SIGNATURE) throw new InvalidDataException($"Unable to validate header signature from file [{filename}]");
            if (header.fieldCount != propertyCount) throw new InvalidDataException($"Unable to validate header field count from file [{filename}] expecting [{propertyCount}] found [{header.fieldCount}]");
            List<T> items = DbcFile.Read<T>(header, content);
            if (items.Count != header.RecordCount) throw new InvalidDataException($"Bad records count in file [{filename}] expecting [{header.RecordCount}] found [{items.Count}]");
            return items;
        }

        internal static DbcLocale GetLocale()
        {
            return Locale;
        }
    }
}
