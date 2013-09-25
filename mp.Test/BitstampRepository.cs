using System.Collections.Generic;
using mp.Models;

namespace mp.Test
{
    public class BitstampRepository
    {
        private BitstampConnector _connection;

        public BitstampRepository(BitstampConnector bitstampConnection)
        {
            _connection = bitstampConnection;
        }

        public BitstampTicker GetTicker()
        {
            return _connection.GetTicker();
        }
    }
}