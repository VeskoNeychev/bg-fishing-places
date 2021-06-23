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
                .Property(x => x.Id)
                .IsRequired();

            builder
                .Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder
                .Property(x => x.Name)
                .HasMaxLength(40)
                .IsRequired();

            builder
                .HasMany(x => x.SimilarNames)
                .WithOne(x => x.Bait)
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
