using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;

namespace HitKino
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		#region Notify
		public event PropertyChangedEventHandler PropertyChanged;
		protected void onPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion;

		public event Action<UserControl> InitNewPage;
		public event Action<object> ClosePage;

		protected void RaiseInitNewPage(UserControl param)
		{
			if (InitNewPage != null)
				InitNewPage(param);
		}

		protected void RaiseClosePage(object param)
		{
			if (ClosePage != null)
				ClosePage(param);
		}
	}
}
