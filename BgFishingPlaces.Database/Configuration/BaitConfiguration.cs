using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BgFishingPlaces.Database.Entities;

namespace BgFishingPlaces.Database.Configuration
{
    public class BaitConfiguration : IEntityTypeConfiguration<Bait>
    {
        public void Configure(EntityTypeBuilder<Bait> builder)
        {
            builder
                .HasKey(x => x.BaitId);

            builder
                .Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder
                .Property(x => x.Name)
                .HasMaxLength(40)
                .IsRequired();

            builder
                .HasMany(x => x.SimilarNames)
                .WithOne(s => s.Bait)
                .HasForeignKey(x => x.BaitId);

            builder
                .HasMany(x => x.Fishes)
                .WithMany(s => s.Baits);

            builder
                .HasOne(x => x.Picture)
                .WithOne(x => x.Bait)
                .HasForeignKey<Bait>(x => x.PictureId);
        }
    }
}
