using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mp.Models;

namespace mp.Controllers
{
    public class BitstampAPIController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value3", "value4" };
        }

        public BitstampTicker Get(int id)
        {
            var ticker = new BitstampTicker();
            ticker.Ask = "23";
            ticker.High = "434.3";
            return ticker;
        }
    }
}
