using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaDB
{
	class RoomsConf: EntityTypeConfiguration<Room>
	{
		public RoomsConf()
		{
			//Настройка полей
			this.Property(r => r.RoomID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(r => r.RoomName).HasColumnType("varchar").HasMaxLength(50);
			this.Property(r => r.Technology).HasColumnType("varchar").HasMaxLength(50);
			this.Property(r => r.RoomSchema).HasColumnType("int").IsRequired();
			this.Property(r => r.Cost).HasColumnType("numeric").HasPrecision(10, 3).IsRequired();

			//Ключевое поле
			this.HasKey(r => r.RoomID);

			//Привязка к таблице
			this.ToTable("Rooms", "Corm");
		}
	}
}
