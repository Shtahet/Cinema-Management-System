using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
	public class Show
	{
		private decimal discount = 1;
		public int ShowID { get; set; }
		public int MovieID { get; set; }
		public int RoomID { get; set; }
		public DateTime Start { get; set; }
		public decimal DiscountLevel
		{
			get { return discount; }
			set { discount = value; }
		}
		public virtual Movie Movie { get; set; }
		public virtual Room Room { get; set; }
		public virtual ICollection<Booking> Bookings { get; set; }
	}
}
