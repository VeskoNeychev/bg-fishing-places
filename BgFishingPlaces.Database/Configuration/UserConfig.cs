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
                .HasMaxLength(50);

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

            builder
                .Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder
                .HasMany(x => x.ReservoirsAdded)
                .WithOne(x => x.AddedByUser)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Roles)
                .WithMany(x => x.Users);

            builder
                .HasMany(x => x.SavedReservoirs)
                .WithOne(x => x.SavedReservoirByUser);

            builder
                .HasMany(x => x.PicturesAddedByUser)
                .WithOne(x => x.UserAdded);
        }
    }
}
