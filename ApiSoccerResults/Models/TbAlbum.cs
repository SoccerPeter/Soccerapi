using System;
using System.Collections.Generic;

#nullable disable

namespace ApiSoccerResults.Models
{
    public partial class TbAlbum
    {
        public int Id { get; set; }
        public string Discid { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int? Ar { get; set; }
        public string Kategori { get; set; }
        public string Bild { get; set; }
        public int? UserId { get; set; }
        public string Media { get; set; }
        public int? Manuell { get; set; }
    }
}
