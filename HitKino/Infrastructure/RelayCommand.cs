using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HitKino
{
	class RelayCommand : ICommand
	{
		private Action<object> _exec;
		private Predicate<object> _canExec;
		public RelayCommand(Action<object> ex, Predicate<object> canEx = null)
		{
			_exec = ex;
			_canExec = canEx;
		}
		public event EventHandler CanExecuteChanged
		{
			add
			{
				CommandManager.RequerySuggested += value;
			}
			remove
			{
				CommandManager.RequerySuggested -= value;
			}
		}

		public bool CanExecute(object parameter)
		{
			return _canExec == null ? true : _canExec(parameter);
		}

		public void Execute(object parameter)
		{
			_exec(parameter);
		}
	}
}
