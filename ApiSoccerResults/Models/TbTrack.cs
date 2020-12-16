using System;
using System.Collections.Generic;

#nullable disable

namespace ApiSoccerResults.Models
{
    public partial class TbTrack
    {
        public int Id { get; set; }
        public int? Nr { get; set; }
        public string Track { get; set; }
        public string Discid { get; set; }
        public int? UserId { get; set; }
    }
}
