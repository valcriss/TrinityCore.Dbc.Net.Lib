using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore.Dbc.Net.Lib.Definitions;

namespace TrinityCore.Dbc.Net.Lib.Tests
{
    [TestClass]
    public class CacheFileTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            DbcDirectory.Initialize(@"C:\Users\Z019817\Documents\dbc", Enums.DbcLocale.frFR);
        }

        [TestMethod]
        public void TestCacheGainTime()
        {
            DateTime startWithoutCache = DateTime.Now;
            List<Spell> records = DbcDirectory.Open<Spell>();
            Assert.IsNotNull(records);
            double withoutCacheDuration = DateTime.Now.Subtract(startWithoutCache).TotalMilliseconds;
            DateTime startWithCache = DateTime.Now;
            List<Spell> recordsCached = DbcDirectory.Open<Spell>();
            Assert.IsNotNull(recordsCached);
            Assert.IsTrue(records.Count == recordsCached.Count);
            double withCacheDuration = DateTime.Now.Subtract(startWithCache).TotalMilliseconds;
            Trace.WriteLine($"Without Cache : {withoutCacheDuration} ms");
            Trace.WriteLine($"With Cache : {withCacheDuration} ms");
            Assert.IsTrue(withoutCacheDuration > withCacheDuration);
        }
    }
}
