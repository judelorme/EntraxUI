using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using WpfApplication1.Model;
using WpfApplication1.Properties;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for FileChooser.xaml
    /// </summary>
    public partial class FileChooser : Window
    {
        public FileChooser()
        {
            InitializeComponent();

            var file = Settings.Default["FilePath"];

            if (!string.IsNullOrEmpty((string) file))
                GlobalDataManager.Instance.FilePath = (string) file;
        }

        private void ChooseFile_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                GlobalDataManager.Instance.FilePath = openFileDialog.FileName;
            }
        }

        private void ContinueButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GlobalDataManager.Instance.FilePath))
                return;

            var res = EntraxModel.Instance.LoadCurrentFile();
            if (!res)
                return;

            if (!string.Equals(Settings.Default["FilePath"], GlobalDataManager.Instance.FilePath))
            {
                Settings.Default["FilePath"] = GlobalDataManager.Instance.FilePath;
                Settings.Default.Save();
            }
            
            this.Hide();
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
