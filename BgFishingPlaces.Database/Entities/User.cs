using System;
using System.Collections.Generic;

namespace BgFishingPlaces.Database.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Address Address { get; set; }

        public virtual Picture ProfilePicture { get; set; }

        public virtual ICollection<Reservoir> AddedReservoirs { get; set; } = new List<Reservoir>();

        public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

        //public virtual ICollection<Reservoir> SavedReservoirs { get; set; } = new List<Reservoir>();

        //public virtual ICollection<Picture> PicturesAddedByUser { get; set; } = new List<Picture>();
    }
}
