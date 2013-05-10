using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using mp.Models;


namespace mp.Test
{
    [TestFixture]
    public class BitstampCacheTests
    {
        private IEnumerable<string> _ticker;
        private BitstampCache _cache;
        [SetUp]
        public void Setup()
        {
            _cache = new BitstampCache();
            _cache.Connect();
            _ticker = _cache.TickerData();
            _cache.Disconnect();
        }

        [Test]
        public void TickerData()
        {
            
            Assert.That(_ticker, Is.Not.Null);
            Assert.That(_ticker.Count(), Is.EqualTo(2));

        }

        [Test]
        public void DisconnectedCache()
        {
            Assert.That(_ticker, Is.EqualTo(_cache.TickerData()));
            Assert.That(_cache.Connected, Is.False);
        }

        [Test]
        public void ConnectedCache()
        {
            _cache.Connect();
            TimeUtils.Waitfor(2000);
            Assert.That(_ticker, Is.Not.EqualTo(_cache.TickerData()));
            Assert.That(_cache.Connected, Is.True);

        }
    }
}
