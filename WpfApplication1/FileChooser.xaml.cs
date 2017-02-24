using System.IO;
using System.Windows;
using Microsoft.Win32;
using WpfApplication1.Model;

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
        }

        private void ChooseFile_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                GlobalDataManager.Instance.FilePath = openFileDialog.FileName;
        }

        private void ContinueButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GlobalDataManager.Instance.FilePath))
                return;

            var res = EntraxModel.Instance.LoadCurrentFile();
            if (!res)
                return;

            this.Hide();
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
