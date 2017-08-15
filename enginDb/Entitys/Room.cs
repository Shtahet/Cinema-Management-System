using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
	public enum RoomSchema { Type1, Type2, Type3};
	public class Room
	{
		public int RoomID { get; set; }
		public string RoomName { get; set; }
		public string Technology { get; set; }
		public RoomSchema RoomSchema { get; set; }
		public decimal Cost { get; set; }
		public virtual ICollection<Show> Shows { get; set; }
		public virtual ICollection<Chair> Chairs { get; set; }
	}
}
