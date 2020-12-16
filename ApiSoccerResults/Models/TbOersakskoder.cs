using System;
using System.Collections.Generic;

#nullable disable

namespace ApiSoccerResults.Models
{
    public partial class TbOersakskoder
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Forklaring { get; set; }
        public bool? Provisionsgrundande { get; set; }
    }
}
