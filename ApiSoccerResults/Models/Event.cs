using System;
using System.Collections.Generic;

#nullable disable

namespace ApiSoccerResults.Models
{
    public partial class Event
    {
        public int Id { get; set; }
        public int? FixtureId { get; set; }
        public int? Elapsed { get; set; }
        public string Player { get; set; }
        public string Type { get; set; }
        public string Team { get; set; }
    }
}
