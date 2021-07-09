using System;
using System.Collections.Generic;

namespace BgFishingPlaces.Database.Entities
{
    public class Bait
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Fish> Fishes { get; set; } = new List<Fish>();

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
