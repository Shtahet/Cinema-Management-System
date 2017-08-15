using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
	public class Movie
	{
		public int MovieID { get; set; }
		public string Name { get; set; }
		public int? MovieYear { get; set; }
		public string Director { get; set; }
		public string About { get; set; }
		public DateTime RentalStartDate { get; set; }
		public DateTime RentalEndDate { get; set; }
		public int Duration { get; set; }
		public byte[] Logo { get; set; }
		public virtual ICollection<Genre> Genres { get; set; }
		public virtual ICollection<Show> Shows { get; set; }
	}
}
