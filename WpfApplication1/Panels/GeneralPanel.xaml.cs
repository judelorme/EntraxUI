using System.Collections.Generic;
using System.ComponentModel;
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

            Etherites = new Dictionary<int, string>
            {
                {2, "Nouvelle Gridania"},
                {3, "Ranch De Brancharquée"},
                {4, "Hutte Des Hawthorne"},
                {5, "Moulin De La Carrière"},
                {6, "Camp Des Sentes Tranquilles"},
                {7, "Lac De La Calebasse"},
                {8, "Limsa Lominsa - L'Entrepont"},
                {9, "Ul'dah - Faubourg De Nald"},
                {10, "Chantier Naval De Moraby"},
                {11, "Costa Del Sol"},
                {12, "Port-aux-Vins"},
                {13, "Le Martinet"},
                {14, "Port-aux-Ales"},
                {15, "Camp Du Lac D\'Airain"},
                {16, "Camp Du Guet"},
                {17, "Horizon"},
                {18, "Camp Des Os Desséchés"},
                {19, "Petite Ala Mhigo"},
                {20, "Oasis Oubliée"},
                {21, "Camp De Brumebleue"},
                {22, "Usine De Céruleum"},
                {23, "Camp De La Tête Du Dragon"},
                {24, "Glas Des Revenants"},
                {52, "Vergers D\'Estival"},
                {53, "Gare De Roncenoire"},
                {55, "Jetée De L'Antre Des Loups"},
                {56, "Maison (compagnie Libre) - Limsa"},
                {57, "Maison (compagnie Libre) - Gridania"},
                {58, "Maison (compagnie Libre) - Ul'dah"},
                {59, "Maison (individuelle) - Limsa"},
                {60, "Maison (individuelle) - Gridania"},
                {61, "Maison (individuelle) - Ul'dah"},
                {62, "Gold Saucer"},
                {70, "Ishgard - L\'Assise"},
                {71, "Nid Du Faucon"},
                {72, "Camp De Cime-des-nuages"},
                {73, "Ok\' Zundu"},
                {74, "Hélice"},
                {75, "Idyllée"},
                {76, "La Penne"},
                {77, "Annexe Trine"},
                {78, "Nid-Mog"},
                {79, "Zénith"}
            };
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
