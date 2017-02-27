using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Windows.Controls;

namespace WpfApplication1.Panels
{
    /// <summary>
    /// Interaction logic for PsyduckPanel.xaml
    /// </summary>
    public partial class PsyduckPanel : UserControl
    {
        public Dictionary<string, string> Patience { get; set; }
        public Dictionary<string, string> Cordial { get; set; }

        public PsyduckPanel()
        {
            InitializeComponent();
            DataContext = this;

            ResourceManager rm = new ResourceManager("WpfApplication1.Properties.Resources",
               Assembly.GetExecutingAssembly());

            Patience = new Dictionary<string, string>
            {
                {"Patience", "Patience"},
                {"Patience2", "Patience II"}
            };

            Cordial = new Dictionary<string, string>
            {
                {"None", Properties.Resources.ResourceManager.GetString("Ui_Cordial_None")},
                {"Cordial", Properties.Resources.ResourceManager.GetString("Ui_Cordial_Cordial")},
                {"HiCordial ", Properties.Resources.ResourceManager.GetString("Ui_Cordial_HiCordial")},
                {"Auto", Properties.Resources.ResourceManager.GetString("Ui_Cordial_Automatic")}
            };
        }
    }
}
