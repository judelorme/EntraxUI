using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace WpfApplication1.Panels
{
    /// <summary>
    /// Interaction logic for TangelaPanel.xaml
    /// </summary>
    public partial class TangelaPanel : UserControl
    {
        public ObservableCollection<string> StarRotations { get; set; }
        public ObservableCollection<string> Rotations { get; set; }
        public Dictionary<string, string> Cordial { get; set; }
        
        public TangelaPanel()
        {
            InitializeComponent();
            DataContext = this;

            StarRotations = new ObservableCollection<string> { "346", "402", "460", "550" };

            Rotations = new ObservableCollection<string> { "346", "402", "460", "550" };
            
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
