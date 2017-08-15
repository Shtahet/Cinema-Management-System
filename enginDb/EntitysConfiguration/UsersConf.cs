using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaDB
{
	class UsersConf: EntityTypeConfiguration<User>
	{
		public UsersConf()
		{
			//Настройка полей
			this.Property(u => u.UserID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(u => u.UserMail).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
			this.Property(u => u.ShaPass).HasColumnType("varbinary").HasMaxLength(256).IsRequired();
			this.Property(u => u.FirstName).HasColumnType("nvarchar").HasMaxLength(100);
			this.Property(u => u.LastName).HasColumnType("nvarchar").HasMaxLength(100);
			this.Property(u => u.LevelID).HasColumnType("int").IsRequired();

			//Ключевое поле
			this.HasKey(u => u.UserID);

			//Привязка к таблице
			this.ToTable("Users", "Corm");
		}
	}
}
