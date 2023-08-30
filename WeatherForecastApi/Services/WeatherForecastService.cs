using WeatherForecastApi.Enums;

namespace WeatherForecastApi.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = WeatherSummary.GetRandomSummary()
            })
           .ToArray();
        }

    }
}
