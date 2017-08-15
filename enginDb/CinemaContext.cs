using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace CinemaDB
{
    public class CinemaContext: DbContext
    {
		public DbSet<AccessLevel> AccessLevels { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Show> Shows { get; set; }
		public DbSet<Chair> Chairs { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		internal CinemaContext(): base("CinemaConnection")
		{ }
		internal CinemaContext(string Connection): base (Connection)
		{ }

		protected override void OnModelCreating (DbModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("Corm");
			modelBuilder.Configurations.Add(new AssetLevelsConf());
			modelBuilder.Configurations.Add(new UsersConf());
			modelBuilder.Configurations.Add(new GenresConf());
			modelBuilder.Configurations.Add(new MoviesConf());
			modelBuilder.Configurations.Add(new RoomsConf());
			modelBuilder.Configurations.Add(new ShowsConf());
			modelBuilder.Configurations.Add(new ChairsConf());
			modelBuilder.Configurations.Add(new BookingsConf());

			//Указание связей между сущностями
			modelBuilder.Entity<User>().HasRequired(u => u.AccessLevel).WithMany(a => a.Users).HasForeignKey(u => u.LevelID).WillCascadeOnDelete(false);
			modelBuilder.Entity<Movie>().HasMany(m => m.Genres).WithMany(g => g.Movies).Map(m =>
			{
				m.ToTable("MoviesGenres");
				m.MapLeftKey("MovieID");
				m.MapRightKey("GenreID");
			});
			modelBuilder.Entity<Show>().HasRequired(s => s.Movie).WithMany(m => m.Shows).HasForeignKey(s => s.MovieID).WillCascadeOnDelete(false);
			modelBuilder.Entity<Show>().HasRequired(s => s.Room).WithMany(r => r.Shows).HasForeignKey(s => s.RoomID).WillCascadeOnDelete(false);
			modelBuilder.Entity<Chair>().HasRequired(c => c.Room).WithMany(r => r.Chairs).HasForeignKey(c => c.RoomID).WillCascadeOnDelete(false);
			modelBuilder.Entity<Booking>().HasRequired(b => b.User).WithMany(u => u.Bookings).HasForeignKey(b => b.UserID).WillCascadeOnDelete(false);
			modelBuilder.Entity<Booking>().HasRequired(b => b.Show).WithMany(s => s.Bookings).HasForeignKey(b => b.ShowID).WillCascadeOnDelete(false);
			modelBuilder.Entity<Booking>().HasRequired(b => b.Chair).WithMany(c => c.Bookings).HasForeignKey(b => b.ChairID).WillCascadeOnDelete(false);

			base.OnModelCreating(modelBuilder);
		}

    }
}
