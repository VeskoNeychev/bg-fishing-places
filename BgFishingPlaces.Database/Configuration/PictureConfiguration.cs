using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BgFishingPlaces.Database.Entities;

namespace BgFishingPlaces.Database.Configuration
{
    public class PictureConfiguration : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder
                .Property(x => x.PictureId)
                .IsRequired();

            builder
                .Property(x => x.PicturePath)
                .HasMaxLength(256)
                .IsRequired();

            builder
               .Property(x => x.PictureExtension)
               .HasMaxLength(8)
               .IsRequired();

            builder
                .Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder
                .HasOne(x => x.Reservoir)
                .WithMany(x => x.Pictures)
                .HasForeignKey(x => x.ReservoirId);

            builder
                .HasOne(x => x.Fish)
                .WithMany(x => x.Pictures)
                .HasForeignKey(x => x.PictureId);

            builder
                .HasOne(x => x.Bait)
                .WithOne(x => x.Picture)
                .HasForeignKey<Picture>(x => x.BaitId);

            builder
                .HasOne(x => x.UserAdded)
                .WithMany(x => x.PicturesAddedByUser)
                .HasForeignKey(x => x.UserAddedId);
        }
    }
}
