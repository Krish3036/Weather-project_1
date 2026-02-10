
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

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
    }
}