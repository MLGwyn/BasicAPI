using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string SayHello(string who = "World")
        {
            // string whoOrWorld = (who == null) ? "World" : who;    //set who default to who (instead of null) above
            // if (who == null)
            // {
            //     whoOrWorld = "World";
            // }                                       //ternary code above to simplify (if value assign value)
            // else
            // {
            //     whoOrWorld = who;
            // }
            return $"Hello, {who}. It is currently {DateTime.Now}";
        }
    }
}
