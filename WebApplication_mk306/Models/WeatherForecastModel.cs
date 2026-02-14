namespace WebApplication_mk306.Models
{
    public class WeatherForecastModel
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }

    public class DatabaseConfig
    {
        public string? DefaultConnection { get; set; }
    }
}