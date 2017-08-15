using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaDB
{
	class ShowsConf: EntityTypeConfiguration<Show>
	{
		public ShowsConf()
		{
			//Настройка полей
			this.Property(s => s.ShowID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(s => s.MovieID).HasColumnType("int").IsRequired();
			this.Property(s => s.RoomID).HasColumnType("int").IsRequired();
			this.Property(s => s.Start).HasColumnType("datetime").IsRequired();
			this.Property(s => s.DiscountLevel).HasColumnType("numeric").HasPrecision(5, 3).IsRequired();

			//Ключевое поле
			this.HasKey(s => s.ShowID);

			//Привязка к таблице
			this.ToTable("Shows", "Corm");
		}
	}
}
