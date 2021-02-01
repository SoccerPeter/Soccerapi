using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiSoccerResults.Models
{
    public partial class dbAppContext : DbContext
    {
        public dbAppContext()
        {
        }

        public dbAppContext(DbContextOptions<dbAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Fixture> Fixtures { get; set; }
        public virtual DbSet<Ligor> Ligors { get; set; }
        public virtual DbSet<TbAlbum> TbAlbums { get; set; }
        public virtual DbSet<TbLeagueStanding> TbLeagueStandings { get; set; }
        public virtual DbSet<TbLoneart> TbLonearts { get; set; }
        public virtual DbSet<TbOersakskoder> TbOersakskoders { get; set; }
        public virtual DbSet<TbTrack> TbTracks { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<VOrder> VOrders { get; set; }
        public virtual DbSet<TopScorer> TopScorers { get; set; }
        public virtual DbSet<TbTeam> TbTeams { get; set; }
        public virtual DbSet<TbLineUp> TbLineUps { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:vlqwv4swf2.database.windows.net,1433;Database=dbApp;User ID=sapjappl@vlqwv4swf2;Password=Olle8910;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasIndex(e => e.FixtureId, "nci_wi_Events_052B21A8C7772D2B8B66D1ECEDE1F5A7");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Elapsed).HasColumnName("elapsed");

                entity.Property(e => e.FixtureId).HasColumnName("fixture_id");

                entity.Property(e => e.Player)
                    .HasMaxLength(50)
                    .HasColumnName("player")
                    .IsFixedLength(true);

                entity.Property(e => e.Team)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbTeam>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .HasColumnName("country");

                entity.Property(e => e.Founded).HasColumnName("founded");

                entity.Property(e => e.LegueId).HasColumnName("legueId");

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .HasColumnName("logo");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.VenueAddress)
                    .HasMaxLength(100)
                    .HasColumnName("venue_address");

                entity.Property(e => e.VenueCapacity).HasColumnName("venue_capacity");

                entity.Property(e => e.VenueCity)
                    .HasMaxLength(100)
                    .HasColumnName("venue_city");

                entity.Property(e => e.VenueName)
                    .HasMaxLength(100)
                    .HasColumnName("venue_name");

                entity.Property(e => e.VenueSurface)
                    .HasMaxLength(50)
                    .HasColumnName("venue_surface");
            });

            modelBuilder.Entity<TbLineUp>(entity =>
            {
                entity.ToTable("tbLineUps");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Player).HasMaxLength(100);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Team).HasMaxLength(100);
            });

            modelBuilder.Entity<TopScorer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Appearences).HasColumnName("appearences");

                entity.Property(e => e.CardRed).HasColumnName("card_red");

                entity.Property(e => e.CardYellow).HasColumnName("card_yellow");

                entity.Property(e => e.GoalsAssists).HasColumnName("goals_assists");

                entity.Property(e => e.GoalsTotal).HasColumnName("goals_total");

                entity.Property(e => e.LegueId).HasColumnName("Legue_id");

                entity.Property(e => e.MinutesPlayed).HasColumnName("minutes_played");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .HasColumnName("nationality");

                entity.Property(e => e.PenaltyMissed).HasColumnName("penalty_missed");

                entity.Property(e => e.PenaltySuccess).HasColumnName("penalty_success");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .HasColumnName("position");

                entity.Property(e => e.ShotsOn).HasColumnName("shots_on");

                entity.Property(e => e.ShotsTotal).HasColumnName("shots_total");

                entity.Property(e => e.Team).HasMaxLength(100);

                entity.Property(e => e.TeamName)
                    .HasMaxLength(75)
                    .HasColumnName("team_name");
            });

            modelBuilder.Entity<Fixture>(entity =>
            {
                entity.HasKey(e => e.Idnr)
                    .HasName("PK__Fixtures__B770CDB457D31714");

                entity.HasIndex(e => e.Date, "IX_Fixtures_Date");

                entity.HasIndex(e => e.Id, "nci_wi_Fixtures_BEA188AFE3D4CB59A8ABB4B05F1AD322");

                entity.Property(e => e.AwayGoalDetails)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.AwayLineupDefense)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.AwayLineupForward)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.AwayLineupGoalkeeper)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.AwayLineupMidfield)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.AwayLineupSubstitutes).HasColumnType("text");

                entity.Property(e => e.AwayTeam)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.AwayTeamId)
                    .HasMaxLength(100)
                    .HasColumnName("AwayTeam_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.AwayTeamRedCardDetails)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.AwayTeamYellowCardDetails)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.HomeGoalDetails)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.HomeLineupDefense)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.HomeLineupForward)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.HomeLineupGoalkeeper)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.HomeLineupMidfield)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.HomeLineupSubstitutes).HasColumnType("text");

                entity.Property(e => e.HomeTeam)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.HomeTeamId).HasColumnName("HomeTeam_Id");

                entity.Property(e => e.HomeTeamRedCardDetails)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.HomeTeamYellowCardDetails)
                    .HasMaxLength(256)
                    .IsFixedLength(true);

                entity.Property(e => e.League)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Referee)
                    .HasMaxLength(75)
                    .IsFixedLength(true);

                entity.Property(e => e.Round)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Time)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Ligor>(entity =>
            {
                entity.HasKey(e => e.Id1)
                    .HasName("PK__Ligor__C49607F557BE6F8D");

                entity.ToTable("Ligor");

                entity.Property(e => e.Country)
                    .HasMaxLength(75)
                    .IsFixedLength(true);

                entity.Property(e => e.Events).HasColumnName("events");

                entity.Property(e => e.Lineups).HasColumnName("lineups");

                entity.Property(e => e.Livescore)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Standings).HasColumnName("standings");
            });

            modelBuilder.Entity<TbAlbum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbAlbum");

                entity.Property(e => e.Album)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Artist)
                    .HasMaxLength(70)
                    .IsFixedLength(true);

                entity.Property(e => e.Bild)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("bild");

                entity.Property(e => e.Discid)
                    .HasMaxLength(50)
                    .HasColumnName("discid")
                    .IsFixedLength(true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kategori)
                    .HasMaxLength(50)
                    .HasColumnName("kategori")
                    .IsFixedLength(true);

                entity.Property(e => e.Manuell).HasColumnName("manuell");

                entity.Property(e => e.Media)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbLeagueStanding>(entity =>
            {
                entity.ToTable("tbLeagueStandings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GoalDifference).HasColumnName("Goal_Difference");

                entity.Property(e => e.GoalsAgainst).HasColumnName("Goals_Against");

                entity.Property(e => e.GoalsFor).HasColumnName("Goals_For");

                entity.Property(e => e.LigId).HasColumnName("LigID");

                entity.Property(e => e.Liga)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Team)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbLoneart>(entity =>
            {
                entity.ToTable("TbLoneart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FilAgda)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Filnamn)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Forklaring)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.FromDatum).HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.Typ)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbOersakskoder>(entity =>
            {
                entity.ToTable("TbOersakskoder");

                entity.Property(e => e.Forklaring).HasMaxLength(50);

                entity.Property(e => e.Kod).HasMaxLength(10);
            });

            modelBuilder.Entity<TbTrack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTracks");

                entity.Property(e => e.Discid)
                    .HasMaxLength(50)
                    .HasColumnName("discid")
                    .IsFixedLength(true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nr).HasColumnName("nr");

                entity.Property(e => e.Track)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .HasColumnName("Country ")
                    .IsFixedLength(true);

                entity.Property(e => e.HomePageUrl)
                    .HasMaxLength(150)
                    .HasColumnName("HomePageURL ")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Stadium)
                    .HasMaxLength(100)
                    .HasColumnName("Stadium ")
                    .IsFixedLength(true);

                entity.Property(e => e.TeamId).HasColumnName("Team_Id");

                entity.Property(e => e.Wikilink)
                    .HasMaxLength(150)
                    .HasColumnName("WIKILink ")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vOrders");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.LineTotal).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SalesOrderNumber)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
