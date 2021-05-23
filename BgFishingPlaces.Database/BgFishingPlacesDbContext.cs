using BgFishingPlaces.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BgFishingPlaces.Database
{
    public class BgFishingPlacesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public BgFishingPlacesDbContext(DbContextOptions<BgFishingPlacesDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
