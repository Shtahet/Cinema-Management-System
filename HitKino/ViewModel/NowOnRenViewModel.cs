using CinemaDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HitKino
{
	class NowRentViewModel: ViewModelBase
	{
		public NowRentViewModel()
		{
			_movie = Repository.GetInst.CinemaBase.GetMovies(selectedDate);
		}

		private DateTime selectedDate = DateTime.Now;
		public DateTime SelectedDate
		{
			get { return selectedDate; }
			set { selectedDate = value; }
		}
     
		private ObservableCollection<Movie> _movie;

		public ObservableCollection<Movie> Movies
		{
			get
			{
				return _movie;
			}
			set
			{
				_movie = value;
				base.onPropertyChanged("Movies");
			}
		}

		RelayCommand _detail;
		
		public ICommand ShowDetails
		{
			get
			{
				if (_detail == null)
					_detail = new RelayCommand(x =>
					{
						Movie selected = x as Movie;
						if (selected == null) return;
						Repository.GetInst.SelectedMovie = selected;
						RaiseInitNewPage(new MoviDetail());
					});
				return _detail;
			}
		}
	}
}
