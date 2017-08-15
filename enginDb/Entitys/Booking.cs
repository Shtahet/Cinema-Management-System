using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
	public enum StatusBuy { None, Reserved, Sold};
	public class Booking
	{
		public int BookingID { get; set; }
		public int UserID { get; set; }
		public int ShowID { get; set; }
		public int ChairID { get; set; }
		public StatusBuy StatusBuy { get; set; }
		public DateTime DateBuy { get; set; }
		public virtual User User { get; set; }
		public virtual Show Show { get; set; }
		public virtual Chair Chair { get; set; }
	}
}
