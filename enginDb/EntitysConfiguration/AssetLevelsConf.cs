
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaDB
{
	class AssetLevelsConf: EntityTypeConfiguration<AccessLevel>
	{
		public AssetLevelsConf()
		{
			this.Property(c => c.LevelID).HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			this.Property(c => c.LevelName).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
			this.HasKey(c => c.LevelID);

			this.ToTable("AccessLevels", "Corm");
		}
	}
}
