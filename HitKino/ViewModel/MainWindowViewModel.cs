using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace HitKino
{
	class MainWindowViewModel : ViewModelBase
	{
		

		private Stack<UserControl> rent;
		public MainWindowViewModel()
		{
			rent = new Stack<UserControl>();
			UserControl startPage = new NowRent();
			rent.Push(startPage);
			NowRentViewModel vm = (NowRentViewModel)startPage.DataContext;
			vm.InitNewPage += AtachNewControl;
		}
		public UserControl BottomPanel
		{
			get { return rent.Peek(); }
		}
		
		private void AtachNewControl(UserControl param)
		{
			rent.Push(param);
			onPropertyChanged("BottomPanel");
			ViewModelBase vm = (ViewModelBase)param.DataContext;
			vm.InitNewPage += AtachNewControl;
			vm.ClosePage += DetachControl;
		}

		private void DetachControl(object param)
		{
			rent.Pop();
			onPropertyChanged("BottomPanel");
		}
	}
}
