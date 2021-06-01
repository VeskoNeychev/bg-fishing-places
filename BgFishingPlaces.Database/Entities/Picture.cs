using System;

namespace BgFishingPlaces.Database.Entities
{
    public class Picture
    {
        public Guid PictureId { get; set; }

        public string PicturePath { get; set; }

        public string PictureExtension { get; set; }

        public bool IsDeleted { get; set; }

        public Guid ReservoirId { get; set; }

        public virtual Reservoir Reservoir { get; set; }

        public int? FishId { get; set; }

        public virtual Fish Fish { get; set; }

        public int? BaitId { get; set; }

        public Bait Bait { get; set; }

        public Guid UserAddedId { get; set; }

        public User UserAdded { get; set; }
    }
}
