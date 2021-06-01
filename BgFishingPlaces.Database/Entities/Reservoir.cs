using System;
using System.Collections.Generic;

namespace BgFishingPlaces.Database.Entities
{
    public class Reservoir
    {
        public Guid ReservoirId { get; set; }

        public string ReservoirName { get; set; }

        public string ReservoirAddress { get; set; }

        public string ReservoirCoordinates { get; set; }

        public virtual ICollection<Fish> Fishes { get; set; } = new List<Fish>();

        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();

        public virtual ICollection<SimilarName> SimilarNames { get; set; } = new List<SimilarName>();

        public Guid AddedByUserId { get; set; }

        public virtual User AddedByUser { get; set; }

        public string CreatedOn { get; set; }

        public bool IsApproved { get; set; }

        public bool IsDeleted { get; set; }

        public int ApprovalCounter { get; set; }


        //public virtual ICollection<Approval> ApprovedByUsers { get; set; } = new List<Approval>();

        //public virtual ICollection<Update> LastUpdatedOnByUserId { get; set; } = new List<Update>();

        public Guid SavedReservoirUserId { get; set; }

        public virtual User SavedReservoirByUser { get; set; }

        public string ReservoirDescription { get; set; }
    }
}
