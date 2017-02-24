using System;
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
        }

        protected override void OnDeactivated(EventArgs e)
        {
            EntraxModel.Instance.SaveChanges();
        }
    }
}
