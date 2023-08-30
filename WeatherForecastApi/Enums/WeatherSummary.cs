namespace WeatherForecastApi.Enums
{
    public static class WeatherSummary
    {
        public static readonly string[] Summaries = new[]
        {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching"
        };

        public static string GetRandomSummary()
        {
            return Summaries[Random.Shared.Next(Summaries.Length)];
        }
    }
}