using System;
using System.Collections.Generic;

namespace BgFishingPlaces.Database.Entities
{
    public class Reservoir
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CreatedOn { get; set; }

        public bool IsApproved { get; set; }

        public bool IsDeleted { get; set; }

        public int ApprovalCounter { get; set; }

        public string Description { get; set; }

        public Guid AddressId { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Fish> Fishes { get; set; } = new List<Fish>();

        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();

        public virtual ICollection<SimilarName> SimilarNames { get; set; } = new List<SimilarName>();
    }
}
