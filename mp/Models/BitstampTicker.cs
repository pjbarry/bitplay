using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mp.Models
{
    public class BitstampTicker
    {
        public string High;
        public string Last;
        public string Bid;
        public string Volume;
        public string Low;
        public string Ask;
        private DateTimeOffset _datum;
        

        public bool Fresh
        {
            get { return (_datum != DateTimeOffset.MinValue) && (Math.Abs((DateTimeOffset.UtcNow - _datum).Ticks) < 10000000); }
        }

        public BitstampTicker()
        {
           
        }

        public void Timestamp()
        {
            if (_datum == DateTimeOffset.MinValue)
            {
                _datum = DateTimeOffset.UtcNow;
            }
        }
    }
}