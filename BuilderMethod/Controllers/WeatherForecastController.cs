using BuilderMethod.Builder;
using BuilderMethod.Director;
using BuilderMethod.Product;
using Microsoft.AspNetCore.Mvc;

namespace BuilderMethod.Controllers
{
    [Route("[controller]/[action]")]
    public class WeatherForecastController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetHero()
        {
            var director = new HeroDirector();
            var builder = new HumanHeroBuilder();
            director.Builder = builder;

            director.createHeroBasic();
            Console.WriteLine(builder.build().Armor);
            return Ok("Servicio Ok" + builder.build().toString());
        }
    }
}