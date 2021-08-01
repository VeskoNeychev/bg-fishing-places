using System;
using BgFishingPlaces.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BgFishingPlaces.Database.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .Property(x => x.Id)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.Country)
                .HasMaxLength(50);

            builder
                .Property(x => x.Town)
                .HasMaxLength(30);

            builder
                .Property(x => x.Street)
                .HasMaxLength(30);

            builder
                .Property(x => x.PostCode)
                .HasMaxLength(10);

            builder
                .Property(x => x.Coordinates)
                .HasMaxLength(100);
        }
    }
}
