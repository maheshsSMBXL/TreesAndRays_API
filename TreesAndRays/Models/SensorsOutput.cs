namespace TreesAndRays.Models
{
    public class SensorsOutput
    {
        public int? UserId { get; set; }
        public decimal? TempCelsius { get; set; }
        public decimal? TempFahrenheit { get; set; }
        public decimal? HumidityPercentage { get; set; }
        public decimal? Moisture { get; set; }
        public decimal? MoisturePercentage { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
