using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class DemoController : ApiController
    {
        public String Get()
        {
            return "Welcome To Web API";
        }

        public List<string> Get(int id)
        {
            return new List<string>
            {
                "Data 1",
                "Data2"
            };
        }
    }
}
