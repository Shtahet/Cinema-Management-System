using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDB;
using System.Configuration;

namespace HitKino
{
	class Repository
	{
		private static Repository inst;

		public static Repository GetInst
		{
			get
			{
				if (inst == null)
					inst = new Repository();
				return inst;
			}
		}
		private Repository()
		{
			var connSetings = ConfigurationManager.ConnectionStrings["CinemaConnection"].ConnectionString;
			db = new CinemaBase(connSetings);
		}

		private CinemaBase db;
		public CinemaBase CinemaBase
		{
			get { return db; }
		}

		private Movie selMovie;
		public Movie SelectedMovie
		{
			get { return selMovie; }
			set { selMovie = value; }
		}
	}
}
