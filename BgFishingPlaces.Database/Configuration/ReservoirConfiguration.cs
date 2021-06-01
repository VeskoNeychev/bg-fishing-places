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
                .Property(x => x.ReservoirId)
                .IsRequired();

            builder
                .Property(x => x.ReservoirName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.ReservoirAddress)
                .HasMaxLength(256);

            builder
                .Property(x => x.ReservoirCoordinates)
                .HasMaxLength(80);

            builder
                .HasMany(x => x.Fishes)
                .WithMany(x => x.Reservoirs);

            builder
                .HasMany(x => x.Pictures)
                .WithOne(x => x.Reservoir)
                .HasForeignKey(x => x.ReservoirId);

            builder
                .HasMany(x => x.SimilarNames)
                .WithOne(x => x.Reservoir)
                .HasForeignKey(x => x.ReservoirId);

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

            builder
              .HasOne(x => x.SavedReservoirByUser)
              .WithMany(x => x.SavedReservoirs)
              .OnDelete(DeleteBehavior.Restrict)
              .HasForeignKey(x => x.SavedReservoirUserId);

            builder
              .HasOne(x => x.AddedByUser)
              .WithMany(x => x.ReservoirsAdded)
              .OnDelete(DeleteBehavior.Restrict)
              .HasForeignKey(x => x.AddedByUserId);
        }
    }
}
