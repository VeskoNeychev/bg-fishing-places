using System.Collections.Generic;

namespace BgFishingPlaces.Database.Entities
{
    public class Bait
    {
        public int BaitId { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Fish> Fishes { get; set; } = new List<Fish>();

        public virtual ICollection<SimilarName> SimilarNames { get; set; } = new List<SimilarName>();

        public int? PictureId { get; set; }

        public virtual Picture Picture { get; set; }
    }
}
