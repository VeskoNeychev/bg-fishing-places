using System;

namespace BgFishingPlaces.Database.Entities
{
    public class Picture
    {
        public Guid Id { get; set; }

        public string Path { get; set; }

        public string Extension { get; set; }

        public bool IsDeleted { get; set; }
    }
}
