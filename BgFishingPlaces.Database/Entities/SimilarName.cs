using System;

namespace BgFishingPlaces.Database.Entities
{
    public class SimilarName
    {
        public int SimilarNameId { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? ReservoirId { get; set; }

        public virtual Reservoir Reservoir { get; set; }

        public int? BaitId { get; set; }

        public virtual Bait Bait { get; set; }

        public Guid? FishId { get; set; }

        public virtual Fish Fish { get; set; }
    }
}