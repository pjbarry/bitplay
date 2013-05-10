using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mp.Controllers
{
    public class BitstampAPIController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value3", "value4" };
        }
    }
}
