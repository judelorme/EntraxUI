using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
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
        }

        protected override void OnDeactivated(EventArgs e)
        {
            EntraxModel.Instance.SaveChanges();

            if (GlobalDataManager.Instance.PreviousCurrentCulture != null)
                Thread.CurrentThread.CurrentCulture = GlobalDataManager.Instance.PreviousCurrentCulture;
            if (GlobalDataManager.Instance.PreviousCurrentUICulture != null)
                Thread.CurrentThread.CurrentUICulture = GlobalDataManager.Instance.PreviousCurrentUICulture;
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

            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ChangeLanguageButton_OnClick(object sender, RoutedEventArgs e)
        {
            EntraxModel.Instance.SaveChanges();
            ChangeLanguage();
        }
    }

    public static class ExtensionMethods
    {
        private static Action EmptyDelegate = delegate() { };

        public static void Refresh(this UIElement uiElement)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }
    }
}
