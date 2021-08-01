using System;

namespace BgFishingPlaces.Database.Entities
{
    public class SimilarName
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}