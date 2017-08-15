using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace CinemaDB
{
	class ChairsConf: EntityTypeConfiguration<Chair>
	{
		public ChairsConf()
		{
			//Настройка полей
			this.Property(c => c.ChairID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(c => c.RoomID).HasColumnType("int").IsRequired()
				.HasColumnAnnotation(
					IndexAnnotation.AnnotationName,
					new IndexAnnotation(
						new IndexAttribute("IDX_NC_RoomRowPlace", 1) { IsUnique = true }));
			this.Property(c => c.Row).HasColumnType("int").IsRequired()
				.HasColumnAnnotation(
					IndexAnnotation.AnnotationName,
					new IndexAnnotation(
						new IndexAttribute("IDX_NC_RoomRowPlace", 2) { IsUnique = true }));
			this.Property(c => c.Place).HasColumnType("int").IsRequired()
				.HasColumnAnnotation(
					IndexAnnotation.AnnotationName,
					new IndexAnnotation(
						new IndexAttribute("IDX_NC_RoomRowPlace", 3) { IsUnique = true }));
			this.Property(c => c.PlaceType).HasColumnType("int").IsRequired();

			//Ключевое поле
			this.HasKey(c => c.ChairID);

			//Привязка к таблице
			this.ToTable("Chairs", "Corm");
		}
	}
}
