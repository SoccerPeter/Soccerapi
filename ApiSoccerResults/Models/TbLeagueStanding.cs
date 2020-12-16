using System;
using System.Collections.Generic;

#nullable disable

namespace ApiSoccerResults.Models
{
    public partial class TbLeagueStanding
    {
        public int Id { get; set; }
        public string Liga { get; set; }
        public string Team { get; set; }
        public int? Played { get; set; }
        public int? PlayedAtHome { get; set; }
        public int? PlayedAway { get; set; }
        public int? Won { get; set; }
        public int? Draw { get; set; }
        public int? Lost { get; set; }
        public int? GoalsFor { get; set; }
        public int? GoalsAgainst { get; set; }
        public int? GoalDifference { get; set; }
        public int? Points { get; set; }
        public int? LigId { get; set; }
    }
}
