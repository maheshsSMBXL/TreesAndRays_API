using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TreesAndRays.Data
{
    public class SensorsData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public decimal? TempCelsius { get; set; }
        public decimal? TempFahrenheit { get; set; }
        public decimal? HumidityPercentage { get; set; }
        public decimal? Moisture { get; set; }
        public decimal? MoisturePercentage { get; set; }
        public DateTime CreatedDate { get; set; }        
    }
}
