using System;
namespace ApiSoccerResults.Models
{
    public partial class TopScorer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public string Nationality { get; set; }
        public string TeamName { get; set; }
        public int? Appearences { get; set; }
        public int? MinutesPlayed { get; set; }
        public int? GoalsTotal { get; set; }
        public int? GoalsAssists { get; set; }
        public int? ShotsTotal { get; set; }
        public int? ShotsOn { get; set; }
        public int? PenaltySuccess { get; set; }
        public int? PenaltyMissed { get; set; }
        public int? CardYellow { get; set; }
        public int? CardRed { get; set; }
        public int? LegueId { get; set; }
    }
}
