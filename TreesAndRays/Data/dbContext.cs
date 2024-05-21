using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TreesAndRays.Services;

namespace TreesAndRays.Data
{
    public partial class dbContext : DbContext, IdbContext
    {
        public dbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<SensorsData> SensorsData { get; set; }
        public virtual DbSet<DeviceDataControl> DeviceDataControl { get; set; }
        
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
