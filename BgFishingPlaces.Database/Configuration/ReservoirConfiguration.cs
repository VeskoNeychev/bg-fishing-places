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
                .Property(x => x.Address)
                .HasMaxLength(256);

            builder
                .Property(x => x.Coordinates)
                .HasMaxLength(80);

            builder
                .HasMany(x => x.Fishes)
                .WithMany(x => x.Reservoirs);

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
                .Property(x => x.ReservoirDescription)
                .HasMaxLength(1024);
        }
    }
}
