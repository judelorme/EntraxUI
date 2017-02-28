using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using WpfApplication1.Model;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private readonly MainWindow _parent;
        public MainPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _parent = mainWindow;

            if (GlobalDataManager.Instance.CurrentOpenTab != -1)
            {
                TabControl.SelectedIndex = GlobalDataManager.Instance.CurrentOpenTab;
            }

            TabControl.SelectionChanged += new SelectionChangedEventHandler((sender, e) =>
            {
                GlobalDataManager.Instance.CurrentOpenTab = TabControl.SelectedIndex;
            });
        }

        public void ChangeLanguage()
        {
            GlobalDataManager.Instance.PreviousCurrentCulture = GlobalDataManager.Instance.CurrentCulture;
            GlobalDataManager.Instance.PreviousCurrentUICulture = GlobalDataManager.Instance.CurrentUICulture;

            CultureInfo culture;
            if (GlobalDataManager.Instance.PreviousCurrentCulture == null || GlobalDataManager.Instance.PreviousCurrentCulture.Name != "en-US")
                culture = new CultureInfo("en-US");
            else
                culture = new CultureInfo("fr-FR");

            Thread.CurrentThread.CurrentCulture = culture;
            GlobalDataManager.Instance.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            GlobalDataManager.Instance.CurrentUICulture = culture;

            _parent.GoToMainPage();
        }

        private void ChangeLanguageButton_OnClick(object sender, RoutedEventArgs e)
        {
            EntraxModel.Instance.SaveChanges();
            ChangeLanguage();
        }
    }
}
