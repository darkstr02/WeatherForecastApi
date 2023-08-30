namespace WeatherForecastApi.Services
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}