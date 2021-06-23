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
                .Property(x => x.Id)
                .IsRequired();

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}
