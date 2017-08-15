using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CinemaDB
{
	public class CinemaBase
	{
		#region Constructors
		public CinemaBase()
		{
			context = new CinemaContext();
		}
		public CinemaBase(string conn)
		{
			context = new CinemaContext(conn);
		}
		#endregion
		public ObservableCollection<Movie> GetMovies(DateTime currDate)
		{
			var res = context.Movies.Include(m => m.Genres)
				.Where(m => m.RentalStartDate <= currDate && m.RentalEndDate >= currDate).ToList();
			return new ObservableCollection<Movie>(res);
		}

		#region Context
		private CinemaContext context;
		public CinemaContext Context
		{
			get { return context; }
		}
		#endregion
	}
}
