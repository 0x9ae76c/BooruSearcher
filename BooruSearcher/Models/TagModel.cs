using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BooruSearcher.ViewModels;
using PropertyChanged;

namespace BooruSearcher.Models {
	[ImplementPropertyChanged]
	public class TagModel {
		public string Name { get; set; }

		public ICommand RemoveCommand { get; }
		public TagModel() {
			RemoveCommand = new ActionCommand(Remove);
		}

		private void Remove() {
			MainViewViewModel.Instance._tags.Remove(this);
		}
	}
}
