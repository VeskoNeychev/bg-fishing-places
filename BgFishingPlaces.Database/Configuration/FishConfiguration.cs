using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BgFishingPlaces.Database.Entities;

namespace BgFishingPlaces.Database.Configuration
{
    public class FishConfiguration : IEntityTypeConfiguration<Fish>
    {
        public void Configure(EntityTypeBuilder<Fish> builder)
        {
            builder
                .Property(x => x.FishId)
                .IsRequired();

            builder
                .Property(x => x.FishName)
                .HasMaxLength(40)
                .IsRequired();

            builder
                .Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder
                .HasMany(x => x.Baits)
                .WithMany(x => x.Fishes);

            builder
                .HasMany(x => x.Reservoirs)
                .WithMany(x => x.Fishes);

            builder
                .HasMany(x => x.SimilarNames)
                .WithOne(x => x.Fish)
                .HasForeignKey(x => x.FishId);

            builder
                .HasMany(x => x.Pictures)
                .WithOne(x => x.Fish)
                .HasForeignKey(x => x.FishId);
        }
    }
}
