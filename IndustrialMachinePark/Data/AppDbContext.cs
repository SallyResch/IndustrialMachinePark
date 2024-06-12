using IndustrialMachinePark.Models;
using Microsoft.EntityFrameworkCore;

namespace IndustrialMachinePark.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Machine> Machines { get; set; }
    }
    
}
