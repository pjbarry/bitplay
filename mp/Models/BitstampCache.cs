using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mp.Models
{
    public class BitstampCache
    {
        private Boolean _connected;
        private IEnumerable<string> _tickerdata; 

        public BitstampCache()
        {
            _connected = true;
            _tickerdata = new string[] { "value3", "value4" };
        }
        public IEnumerable<string> TickerData()
        {
            return _tickerdata;
        }

        public void Disconnect()
        {
            _connected = false;
        }

        public Boolean Connected
        {
            get { return _connected; }
        }

        public void Connect()
        {
            _tickerdata = new string[]{ "value1", "value2"};
            _connected = true;

        }
    }
}