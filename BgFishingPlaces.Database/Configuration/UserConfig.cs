using BgFishingPlaces.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CenturionVoting.Database.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(x => x.Id)
                .IsRequired();

            builder
                .Property(x => x.Username)
                .HasMaxLength(16)
                .IsRequired();

            builder
                .Property(x => x.Email)
                .IsRequired();

            builder
                .Property(x => x.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.PasswordSalt)
                .IsRequired();

            builder
                .Property(x => x.PasswordHash)
                .IsRequired();
        }
    }
}
