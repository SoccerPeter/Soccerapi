using System;
using System.Collections.Generic;

#nullable disable

namespace ApiSoccerResults.Models
{
    public partial class Ligor
    {
        public int Id1 { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Livescore { get; set; }
        public int? UpdateTable { get; set; }
        public bool? Events { get; set; }
        public bool? Lineups { get; set; }
        public bool? Standings { get; set; }
    }
}
