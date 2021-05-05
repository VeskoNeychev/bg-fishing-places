using Microsoft.AspNetCore.Mvc;

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