using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TreesAndRays.Data
{
    public class DeviceDataControl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? MacId { get; set; }
        public bool? Status { get; set; }
    }
}
