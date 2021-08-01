using System;
using System.Collections;
using System.Collections.Generic;

namespace BgFishingPlaces.Database.Entities
{
    public class Role
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
