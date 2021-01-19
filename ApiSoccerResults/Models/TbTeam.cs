using System;
namespace ApiSoccerResults.Models
{
    public partial class TbTeam
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Country { get; set; }
        public int? Founded { get; set; }
        public string VenueName { get; set; }
        public string VenueSurface { get; set; }
        public string VenueAddress { get; set; }
        public string VenueCity { get; set; }
        public int? VenueCapacity { get; set; }
        public int? LegueId { get; set; }
    }
}
