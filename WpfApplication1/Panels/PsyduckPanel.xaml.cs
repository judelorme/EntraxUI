using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            Patience = new Dictionary<string, string>
            {
                {"Patience", "Patience"},
                {"Patience2", "Patience II"}
            };

            Cordial = new Dictionary<string, string>
            {
                {"None", "Aucun"},
                {"Cordial", "Breuvage cordial"},
                {"HiCordial ", "Breuvage cordial supérieur"},
                {"Auto", "Automatique"}
            };
        }
    }
}
