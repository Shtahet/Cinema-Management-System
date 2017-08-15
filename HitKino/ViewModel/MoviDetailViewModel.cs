using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDB;
using System.Windows.Input;

namespace HitKino
{
	public class MoviDetailViewModel: ViewModelBase
	{
		private Movie selMovie;
		public MoviDetailViewModel()
		{
			selMovie = Repository.GetInst.SelectedMovie;
		}
		public string About
		{
			get { return selMovie.About; }
		}
		public string Name
		{
			get { return selMovie.Name; }
		}

		private RelayCommand _back;
		public ICommand Back
		{
			get
			{
				if (_back == null)
					_back = new RelayCommand(x => { RaiseClosePage(selMovie); });
				return _back;
			}
		}

	}
}
