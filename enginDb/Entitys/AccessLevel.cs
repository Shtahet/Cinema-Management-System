using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
	public class AccessLevel
	{
		public int LevelID { get; set; }
		public string LevelName { get; set; }
		public virtual ICollection<User> Users { get; set; }
	}
}
