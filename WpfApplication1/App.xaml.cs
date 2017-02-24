using System;
using System.Windows;
using WpfApplication1.Model;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            //EntraxModel.Instance.SaveChanges();
        }
    }
}
