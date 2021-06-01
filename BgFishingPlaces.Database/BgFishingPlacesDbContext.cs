using BgFishingPlaces.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BgFishingPlaces.Database
{
    public class BgFishingPlacesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Reservoir> Reservoirs { get; set; }

        public DbSet<Fish> Fishes { get; set; }

        public DbSet<Bait> Baits { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<SimilarName> SimilarNames { get; set; }

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
