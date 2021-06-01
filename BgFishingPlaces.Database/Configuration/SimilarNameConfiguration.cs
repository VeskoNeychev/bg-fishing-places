using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BgFishingPlaces.Database.Entities;

namespace BgFishingPlaces.Database.Configuration
{
    public class SimilarNameConfiguration : IEntityTypeConfiguration<SimilarName>
    {
        public void Configure(EntityTypeBuilder<SimilarName> builder)
        {
            builder
                .HasKey(x => x.SimilarNameId);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder
                .HasOne(x => x.Reservoir)
                .WithMany(x => x.SimilarNames)
                .HasForeignKey(x => x.ReservoirId);

            builder
                .HasOne(x => x.Fish)
                .WithMany(x => x.SimilarNames)
                .HasForeignKey(x => x.FishId);

            builder
                .HasOne(x => x.Bait)
                .WithMany(x => x.SimilarNames)
                .HasForeignKey(x => x.BaitId);
        }
    }
}
