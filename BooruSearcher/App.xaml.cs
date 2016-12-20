using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows;
using BooruSearcher.ViewModels;

namespace BooruSearcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
		private void AppStartup(object sender, StartupEventArgs args) {
			var mainWindow = new MainWindow {
				DataContext = new MainWindowViewModel()
			};
			mainWindow.Show();
		}
	}
}
