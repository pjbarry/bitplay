using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mp.Models
{
    public class BitstampCache
    {
        private Boolean _Connected;
        public IEnumerable<string> TickerData()
        {
            return new string[] { "value3", "value4" };
        }

        public void Disconnect()
        {
            _Connected = false;
        }

        public Boolean Connected
        {
            get { return _Connected; }
        }

        public void Connect()
        {
            _Connected = true;
        }
    }
}