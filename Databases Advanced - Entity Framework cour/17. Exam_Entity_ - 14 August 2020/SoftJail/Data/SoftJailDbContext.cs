namespace SoftJail.Data
{
	using Microsoft.EntityFrameworkCore;
    using SoftJail.Data.Models;

    public class SoftJailDbContext : DbContext
	{
		public SoftJailDbContext()
		{
		}

		public SoftJailDbContext(DbContextOptions options)
			: base(options)
		{
		}


		public DbSet<OfficerPrisoner> OfficersPrisoners { get; set; }

		public DbSet<Officer> Officers { get; set; }

		public DbSet<Prisoner> Prisoners { get; set; }

		public DbSet<Mail> Mails { get; set; }

		public DbSet<Cell> Cells { get; set; }

		public DbSet<Department> Departments { get; set; }




		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder
					.UseSqlServer(Configuration.ConnectionString);
			}
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{

			builder.Entity<OfficerPrisoner>(e =>
			{
				//Entity Configuration
				e.HasKey(et => new { et.PrisonerId, et.OfficerId });

			});

			builder.Entity<Prisoner>(entity =>
			{
				entity.HasMany(x => x.Mails)
					  .WithOne(x => x.Prisoner)
					  .HasForeignKey(x => x.PrisonerId);


				entity.HasMany(x => x.PrisonerOfficers)
					  .WithOne(x => x.Prisoner)
					  .HasForeignKey(x => x.PrisonerId)
					  .OnDelete(DeleteBehavior.Restrict);
			});

			builder.Entity<Officer>(entity =>
			{
				entity.HasMany(x => x.OfficerPrisoners)
					  .WithOne(x => x.Officer)
					  .HasForeignKey(x => x.OfficerId)
					   .OnDelete(DeleteBehavior.Restrict);


			});

			//builder.Entity<Prisoner>(entity =>
			//{
			//	entity.Property(e => e.Bail).IsRequired();

			//	entity.Property(e => e.FullName).IsRequired();


			//});

			

			//e.HasOne(g => g.HomeTeam)
			//	 .WithMany(t => t.HomeGames)
			//	 .HasForeignKey(g => g.HomeTeamId)
			//	 .OnDelete(DeleteBehavior.Restrict);


			//e.HasOne(g => g.AwayTeam)
			//  .WithMany(t => t.AwayGames)
			//  .HasForeignKey(g => g.AwayTeamId)
			//  .OnDelete(DeleteBehavior.Restrict);


		}
	}
}