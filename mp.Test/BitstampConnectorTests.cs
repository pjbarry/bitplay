using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using mp.Models;

namespace mp.Test
{
    [TestFixture]
    class BitstampConnectorTests
    {
        [Test]
        public void GetTicker()
        {
            var connector = new BitstampConnector("https://www.bitstamp.net/api");
            BitstampTicker ticker =connector.GetTicker();
            Assert.That(ticker,Is.Not.Null);
            Assert.That(ticker.Fresh,Is.EqualTo(true));

        }

    }
}
