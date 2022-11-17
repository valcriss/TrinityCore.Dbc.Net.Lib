using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore.Dbc.Net.Lib.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DbcFileAttribute : Attribute
    {
        public string Filename { get; set; }

        public DbcFileAttribute(string filename)
        {
            Filename = filename;
        }
    }
}
