using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BgFishingPlaces.Database.Entities;

namespace BgFishingPlaces.Database.Configuration
{
    public class ReservoirConfiguration : IEntityTypeConfiguration<Reservoir>
    {
        public void Configure(EntityTypeBuilder<Reservoir> builder)
        {
            builder
                .Property(x => x.Id)
                .IsRequired();

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.CreatedOn)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(x => x.IsApproved)
                .HasDefaultValue(false);

            builder
                .Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder
                .Property(x => x.Description)
                .HasMaxLength(1024);
        }
    }
}
