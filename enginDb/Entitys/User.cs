using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
	public class User
	{
		public int UserID { get; set; }
		public string UserMail { get; set; }
		public byte[] ShaPass { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int LevelID { get; set; }
		public virtual AccessLevel AccessLevel { get; set; }
		public virtual ICollection<Booking> Bookings { get; set; }
	}
}
