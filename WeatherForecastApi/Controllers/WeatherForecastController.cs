using Microsoft.AspNetCore.Mvc;
using WeatherForecastApi.Services;


namespace WeatherForecastApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<List<WeatherForecast>> Get()
        {
            var weatherForecasts = _weatherForecastService.GetWeatherForecasts();
            return Ok(weatherForecasts);
        }
    }
}