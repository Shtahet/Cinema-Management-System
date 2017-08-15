using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
	public enum PlaceType { Normal, VIP};
	public class Chair
	{
		private int row;
		private int place;
		public int ChairID { get; set; }
		public int RoomID { get; set; }
		public int Row
		{
			get { return row; }
			set
			{
				if (value > 0)
					row = value;
				else
					new ArgumentOutOfRangeException($"Недопустимое значение параметра Row={value}. Значение должно быть больше 0.");
			}
		}
		public int Place
		{
			get { return place; }
			set
			{
				if (value > 0)
					place = value;
				else
					new ArgumentOutOfRangeException($"Недопустимое значение параметра Place={value}. Значение должно быть больше 0.");
			}

		}
		public PlaceType PlaceType { get; set; }
		public virtual ICollection<Booking> Bookings { get; set; }
		public virtual Room Room { get; set; }
	}
}
