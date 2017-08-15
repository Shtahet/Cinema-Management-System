using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaDB
{
	class GenresConf: EntityTypeConfiguration<Genre>
	{
		public GenresConf()
		{
			//Настройка полей
			this.Property(g => g.GenreID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(g => g.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

			//Ключевое поле
			this.HasKey(g => g.GenreID);

			//Привязка к таблице
			this.ToTable("Genres", "Corm");

		}
	}
}
