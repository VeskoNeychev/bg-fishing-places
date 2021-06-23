using System;

namespace BgFishingPlaces.Database.Entities
{
    public class Picture
    {
        public Guid Id { get; set; }

        public string PicturePath { get; set; }

        public string PictureExtension { get; set; }

        public bool IsDeleted { get; set; }
    }
}
