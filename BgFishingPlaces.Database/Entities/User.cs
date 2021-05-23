using System;
using System.Collections.Generic;

namespace BgFishingPlaces.Database.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public Guid VoterId { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public ICollection<Role> Roles { get; set; } = new List<Role>();
    }
}
