using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using Mosaic4.Engine;
using Mosaic4.Entities;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Mosaic4
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private MosaicProject _project = new MosaicProject();

        public MosaicProject Project
        {
            get
            {
                return _project;
            }

            set
            {
                if (_project != value)
                {
                    _project = value;
                    OnPropertyChanged("Project");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		public void OriginalBrowse() {
			Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();

			if (dialog.ShowDialog() == true) {
				_project.OriginalPath = dialog.FileName;
			}
		}

		public void TilesBrowse() {
			FolderBrowserDialog dialog = new FolderBrowserDialog();

			if (dialog.ShowDialog() == DialogResult.OK) {
				_project.TilesPath = dialog.SelectedPath;
			}
		}

		public void FinalBrowse() {
			Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();

			if (dialog.ShowDialog() == true) {
				_project.FinalPath = dialog.FileName;
			}
		}
    }
}
