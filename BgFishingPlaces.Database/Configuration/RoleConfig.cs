using BgFishingPlaces.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CenturionVoting.Database.Configurations
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder
                .Property(x => x.Name)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .HasMany(x => x.Users)
                .WithMany(x => x.Roles);

            builder
                .HasData(
                    new Role
                    {
                        Id = Guid.Parse("9f4d859f-74fc-49e2-8b7e-7040fba11d55"),
                        Name = "Admin",
                    });
        }
    }
}
