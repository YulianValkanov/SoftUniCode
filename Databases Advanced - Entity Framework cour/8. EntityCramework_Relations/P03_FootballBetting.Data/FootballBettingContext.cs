﻿

namespace P03_FootballBetting.Data
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data.Models;

    public class FootballBettingContext : DbContext
    {

        //To test  
        public FootballBettingContext()
        {

        }

        //for judge - connection string - For outer connections
        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {

        }

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Color> Colors { get; set; }

        public virtual DbSet<Town> Towns { get; set; }

        public virtual DbSet<Country> Countrys { get; set; }

        public virtual DbSet<Player> Players { get; set; }

        public virtual DbSet<Position> Positions { get; set; }

        public virtual DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        public virtual DbSet<Game> Games { get; set; }

        public virtual DbSet<Bet> Bets { get; set; }

        public virtual DbSet<User> Users { get; set; }

        //To configure connection with your server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        // DDL - database realtions
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PlayerStatistic>(e =>
            {
                e.HasKey(k => new { k.GameId, k.PlayerId });
            });


            modelBuilder.Entity<Team>(e =>
            {
                e.HasOne(t =>
                t.PrimaryKitColor)
                    .WithMany(c => c.PrimaryKitTeams)
                    .HasForeignKey(t => t.PrimaryKitColorId)
                    .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(t =>
                t.SecondaryKitColor)
                    .WithMany(c => c.SeconcaryKitTeams)
                    .HasForeignKey(t => t.SecondaryKitColorId)
                    .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<Game>(e =>
            {
                e.HasOne(g => g.HomeTeam)
                  .WithMany(t =>t.HomeGames)
                  .HasForeignKey(g => g.HomeTeamId)
                  .OnDelete(DeleteBehavior.Restrict);


                e.HasOne(g => g.AwayTeam)
                  .WithMany(t => t.AwayGames)
                  .HasForeignKey(g => g.AwayTeamId)
                  .OnDelete(DeleteBehavior.Restrict);




            });
        }
    }
}
