using System;
using System.Collections.Generic;
using System.Text;

namespace BgFishingPlaces.Database.Entities
{
    public class Address
    {
        public Guid Id { get; set; }

        public string Country { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }

        public int? StreetNumber { get; set; }

        public string PostCode { get; set; }

        public string Coordinates { get; set; }

        public virtual Reservoir Reservoir { get; set; }
    }
}
