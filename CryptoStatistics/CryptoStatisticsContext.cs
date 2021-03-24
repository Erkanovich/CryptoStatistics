using CryptoStatistics.ContextConfigurations;
using CryptoStatistics.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoStatistics
{
    public class CryptoStatisticsContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<GfxSettings> GfxSettings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=CryptoStatistics;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GfxSettingsConfiguration());
            modelBuilder.ApplyConfiguration(new SessionConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
