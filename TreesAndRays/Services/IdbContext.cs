using Microsoft.EntityFrameworkCore;
using TreesAndRays.Data;

namespace TreesAndRays.Services
{
    public interface IdbContext
    {
        DbSet<SensorsData> SensorsData { get; set; }
        DbSet<DeviceDataControl> DeviceDataControl { get; set; }
        
        int SaveChanges();
    }
}
