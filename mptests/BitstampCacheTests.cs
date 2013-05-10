using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using mptest1.Models;


namespace mptest1
{
    [TestFixture]
    public class BitstampCacheTests
    {
        

        [Test]
        public void TickerData()
        {
            var bitstampCache = new BitstampCache();
            var ticker = bitstampCache.TickerData();
            Assert.That(ticker, Is.Not.Null);
            Assert.That(ticker.Count(), Is.EqualTo(2));

        }

        [Test]
        public void DisconnectedCache()
        {
            var bitstampCache = new BitstampCache();
            var ticker = bitstampCache.TickerData();
            bitstampCache.Disconnect();
            Assert.That(ticker, Is.EqualTo(bitstampCache.TickerData()));
            Assert.That(bitstampCache.Connected, Is.False);
        }

        [Test]
        public void ConnectedCache()
        {
            var bitstampCache = new BitstampCache();
            bitstampCache.Disconnect();
            var ticker = bitstampCache.TickerData();
            bitstampCache.Connect();
            TimeUtils.Waitfor(2000);
            Assert.That(ticker, Is.Not.EqualTo(bitstampCache.TickerData()));
            Assert.That(bitstampCache.Connected, Is.True);

        }
    }
}
