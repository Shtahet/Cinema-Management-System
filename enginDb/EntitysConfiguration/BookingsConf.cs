using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaDB
{
	class BookingsConf: EntityTypeConfiguration<Booking>
	{
		public BookingsConf()
		{
			//Настройка полей
			this.Property(b => b.BookingID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(b => b.UserID).HasColumnType("int").IsRequired();
			this.Property(b => b.ShowID).HasColumnType("int").IsRequired();
			this.Property(b => b.ChairID).HasColumnType("int").IsRequired();
			this.Property(b => b.StatusBuy).HasColumnType("int").IsRequired();
			this.Property(b => b.DateBuy).HasColumnType("datetime").IsRequired();

			//Ключевое поле
			this.HasKey(b => b.BookingID);

			//Привязка к таблице
			this.ToTable("Bookings", "Corm");
		}
	}
}
