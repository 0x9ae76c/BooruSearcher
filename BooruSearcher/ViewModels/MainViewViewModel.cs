using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooruSearcher.Models;
using PropertyChanged;

namespace BooruSearcher.ViewModels {
	[ImplementPropertyChanged]
	public class MainViewViewModel {

		public ObservableCollection<TagModel> _tags = new ObservableCollection<TagModel>();
		public ObservableCollection<ImageModel> _images = new ObservableCollection<ImageModel>();
		public  ReadOnlyObservableCollection<TagModel> Tags { get; }

		public ReadOnlyObservableCollection<ImageModel> Images { get; }

		public static MainViewViewModel Instance;

		public MainViewViewModel() {
			Instance = this;
			Tags = new ReadOnlyObservableCollection<TagModel>(_tags);
			Images = new ReadOnlyObservableCollection<ImageModel>(_images);


			_images.Add( new ImageModel {
				Url = new Uri("https://avatars1.githubusercontent.com/u/6447030?v=3&s=460"),
				Name = "Tensei"
			});

			_tags.Add(new TagModel {
				Name = "hxyivyi,"
			});
		}
	}
}
