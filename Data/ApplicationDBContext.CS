
using BarberSchedules.Models;
using BarberSchedules.Services;
using Microsoft.EntityFrameworkCore;

namespace BarberSchedules.Data
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options) { }

        public DbSet<LocationModel> Location { get; set; }
        public DbSet<ScheduleModel> Schedule { get; set; }
        public DbSet<ServiceModel> Service { get; set; }
        public DbSet<UserModel> User { get; set; }
    }
}
