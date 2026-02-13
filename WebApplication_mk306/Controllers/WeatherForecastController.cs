
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication_mk306.Models;

namespace TestProj2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public WeatherForecastController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string? Get()
        {
            return _configuration["Message"];
        }
        [HttpGet("info")]
        public IActionResult Info()
        {
            return Ok("This is GET Info endpoint");
        }

        // POST /WeatherForecast/data
        [HttpPost("WeatherData")]
        public IActionResult WeatherData([FromBody] WeatherForecastModel weatherrequest )
        {

            return Ok(weatherrequest);
          
        }
    }

}