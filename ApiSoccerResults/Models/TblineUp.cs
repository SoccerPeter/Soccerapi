using System;
namespace ApiSoccerResults.Models
{
    public partial class TbLineUp
    {
        public int Id { get; set; }
        public string Player { get; set; }
        public string Position { get; set; }
        public int? Number { get; set; }
        public int? Starter { get; set; }
        public string Team { get; set; }
        public int? FixtureId { get; set; }
    }
}
