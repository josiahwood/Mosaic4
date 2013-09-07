using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mosaic4 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		private MainViewModel _viewModel;

		public MainWindow() {
			_viewModel = new MainViewModel();
			DataContext = _viewModel;

			InitializeComponent();
		}

		private void OriginalBrowse_Click(object sender, RoutedEventArgs e) {
			_viewModel.OriginalBrowse();
		}

		private void TilesBrowse_Click(object sender, RoutedEventArgs e) {
			_viewModel.TilesBrowse();
		}

		private void FinalBrowse_Click(object sender, RoutedEventArgs e) {
			_viewModel.FinalBrowse();
		}
	}
}
