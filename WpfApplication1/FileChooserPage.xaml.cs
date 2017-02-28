using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using WpfApplication1.Model;
using WpfApplication1.Properties;
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for FileChooserPage.xaml
    /// </summary>
    public partial class FileChooserPage : Page
    {
        private MainWindow _parent;
        public FileChooserPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _parent = mainWindow;

            var file = Settings.Default["FilePath"];

            if (!string.IsNullOrEmpty((string)file))
                GlobalDataManager.Instance.FilePath = (string)file;
        }

        private void ChooseFile_OnClick(object sender, RoutedEventArgs e)
        {
            GlobalDataManager.Instance.IsOpeningFileBrowser = true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                GlobalDataManager.Instance.FilePath = openFileDialog.FileName;
            }
            GlobalDataManager.Instance.IsOpeningFileBrowser = false;
        }

        private void ContinueButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
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
                _parent.GoToMainPage();
            }
            catch (Exception ex)
            {
                var message = new MessageBox {Text = ex.Message};
                message.ShowDialog();
            }

        }
    }
}
