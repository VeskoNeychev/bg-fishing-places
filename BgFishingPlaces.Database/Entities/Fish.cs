using System;
using System.Collections.Generic;

namespace BgFishingPlaces.Database.Entities
{
    public class Fish
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Bait> Baits { get; set; } = new List<Bait>();

        public virtual ICollection<Reservoir> Reservoirs { get; set; } = new List<Reservoir>();

        public virtual ICollection<SimilarName> SimilarNames { get; set; } = new List<SimilarName>();

        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
    }
}
