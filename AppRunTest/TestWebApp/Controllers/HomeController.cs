using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestWebApp.Controllers
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            var settings = ConfigurationManager.AppSettings["dbPath"];
            return "Started.... V1 " + settings;
        }
    }
}
