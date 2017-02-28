using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using WpfApplication1.Annotations;
using WpfApplication1.Model;

namespace WpfApplication1.Panels
{
    /// <summary>
    /// Interaction logic for GeneralPanel.xaml
    /// </summary>
    public partial class GeneralPanel : UserControl, INotifyPropertyChanged
    {
        private Dictionary<int, string> _etherites;
        private int _selectedEtherite;

        public Dictionary<int, string> Etherites
        {
            get { return _etherites; }
            set
            {
                if (Equals(value, _etherites)) return;
                _etherites = value;
                OnPropertyChanged();
            }
        }

        public GeneralPanel()
        {
            InitializeComponent();
            DataContext = this;

            ResourceManager rm = new ResourceManager("WpfApplication1.Properties.Resources",
               Assembly.GetExecutingAssembly());

            Etherites = new Dictionary<int, string>();
            var prevEtherites = new Dictionary<int, string>
            {
                {2, rm.GetString("NewGridania")},
                {3, rm.GetString("BentbranchMeadows")},
                {4, rm.GetString("TheHawthorneHut")},
                {5, rm.GetString("Quarrymill")},
                {6, rm.GetString("CampTranquil")},
                {7, rm.GetString("FallgourdFloat")},
                {8, rm.GetString("LimsaLominsaLowerDecks")},
                {9, rm.GetString("UldahStepsofNald")},
                {10, rm.GetString("MorabyDrydocks")},
                {11, rm.GetString("CostadelSol")},
                {12, rm.GetString("Wineport")},
                {13, rm.GetString("Swiftperch")},
                {14, rm.GetString("Aleport")},
                {15, rm.GetString("CampBronzeLake")},
                {16, rm.GetString("CampOverlook")},
                {17, rm.GetString("Horizon")},
                {18, rm.GetString("CampDrybone")},
                {19, rm.GetString("LittleAlaMhigo")},
                {20, rm.GetString("ForgottenSprings")},
                {21, rm.GetString("CampBluefog")},
                {22, rm.GetString("CeruleumProcessingPlant")},
                {23, rm.GetString("CampDragonhead")},
                {24, rm.GetString("RevenantsToll")},
                {52, rm.GetString("SummerfordFarms")},
                {53, rm.GetString("BlackBrushStation")},
                {55, rm.GetString("WolvesDenPier")},
                {56, rm.GetString("EstateHallFreeCompanyLimsa")},
                {57, rm.GetString("EstateHallFreeCompanyGridania")},
                {58, rm.GetString("EstateHallFreeCompanyUldah")},
                {59, rm.GetString("EstateHallPrivateLimsa")},
                {60, rm.GetString("EstateHallPrivateGridania")},
                {61, rm.GetString("EstateHallPrivateUldah")},
                {62, rm.GetString("TheGoldSaucer")},
                {70, rm.GetString("Foundation")},
                {71, rm.GetString("FalconsNest")},
                {72, rm.GetString("CampCloudtop")},
                {73, rm.GetString("OkZundu")},
                {74, rm.GetString("Helix")},
                {75, rm.GetString("Idyllshire")},
                {76, rm.GetString("Tailfeather")},
                {77, rm.GetString("AnyxTrine")},
                {78, rm.GetString("Moghome")},
                {79, rm.GetString("Zenith")}
            };
            
            foreach (var source in prevEtherites.OrderBy(e => e.Value))
            {
                Etherites.Add(source.Key, source.Value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
