using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaDB
{
	class MoviesConf: EntityTypeConfiguration<Movie>
	{
		public MoviesConf ()
		{
			//Настройка полей
			this.Property(m => m.MovieID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
			this.Property(m => m.MovieYear).HasColumnType("int");
			this.Property(m => m.Director).HasColumnType("nvarchar").HasMaxLength(200);
			this.Property(m => m.About).HasColumnType("nvarchar").HasMaxLength(3000);
			this.Property(m => m.RentalStartDate).HasColumnType("datetime").IsRequired();
			this.Property(m => m.RentalEndDate).HasColumnType("datetime").IsRequired();
			this.Property(m => m.Duration).HasColumnType("int").IsRequired();
			this.Property(m => m.Logo).HasColumnType("varbinary(max)");

			//Ключевое поле
			this.HasKey(m => m.MovieID);

			//Привязка к таблице
			this.ToTable("Movies", "Corm");
		}
	}
}
