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
                .Property(x => x.Id)
                .IsRequired();

            builder
                .Property(x => x.Path)
                .HasMaxLength(256)
                .IsRequired();

            builder
               .Property(x => x.Extension)
               .HasMaxLength(8)
               .IsRequired();

            builder
                .Property(x => x.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}
