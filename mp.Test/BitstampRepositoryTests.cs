using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace mp.Test
{
    [TestFixture]
    public class BitstampRepositoryTests
    {
        [Test]
        public void GetTicker()
        {
            var bitstampConnection = new BitstampConnector("https://www.bitstamp.net/api");
            var bitstampRepository = new BitstampRepository(bitstampConnection);
            var ticker = bitstampRepository.GetTicker();
            Assert.That(ticker,Is.Not.Null);
            Assert.That(ticker.Fresh,Is.EqualTo(true));
        }
    }
}
