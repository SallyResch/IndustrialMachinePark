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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Machine>().HasData(new Machine { Name = "Owen small", LatestData = "The machine is ready to start", IsOnline = false });
            modelBuilder.Entity<Machine>().HasData(new Machine { Name = "Dough Maker", LatestData = "Waiting for ingredients", IsOnline = true });
            modelBuilder.Entity<Machine>().HasData(new Machine { Name = "Rolling machine", LatestData = "Latest rolling: marsipan", IsOnline = false });
            modelBuilder.Entity<Machine>().HasData(new Machine { Name = "Beater machine", LatestData = "Waiting for cream to enter the bowl", IsOnline = false });
            modelBuilder.Entity<Machine>().HasData(new Machine { Name = "Owen Medium", LatestData = "The machine is ready to start", IsOnline = false });
            modelBuilder.Entity<Machine>().HasData(new Machine { Name = "Owen Large", LatestData = "The machine is ready to start", IsOnline = false });
        }
    }
    
}
