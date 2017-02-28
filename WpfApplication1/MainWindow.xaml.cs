using System;
using System.Threading;
using System.Windows;
using WpfApplication1.Model;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Content = new FileChooserPage(this);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            EntraxModel.Instance.SaveChanges();

            if (GlobalDataManager.Instance.PreviousCurrentCulture != null)
                Thread.CurrentThread.CurrentCulture = GlobalDataManager.Instance.PreviousCurrentCulture;
            if (GlobalDataManager.Instance.PreviousCurrentUICulture != null)
                Thread.CurrentThread.CurrentUICulture = GlobalDataManager.Instance.PreviousCurrentUICulture;
        }

        public void GoToMainPage()
        {
            this.Content = new MainPage(this);
        }
    }
}
