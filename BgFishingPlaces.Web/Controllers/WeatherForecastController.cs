using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgFishingPlaces.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] TestResult = new[]
        {
            "Test1", "Test2", "Test3"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(TestResult);
        }
    }
}
