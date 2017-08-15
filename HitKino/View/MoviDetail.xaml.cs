using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HitKino
{
	/// <summary>
	/// Interaction logic for MoviDetail.xaml
	/// </summary>
	public partial class MoviDetail : UserControl
	{
		public MoviDetail()
		{
			InitializeComponent();
			this.DataContext = new MoviDetailViewModel();
		}
	}
}
