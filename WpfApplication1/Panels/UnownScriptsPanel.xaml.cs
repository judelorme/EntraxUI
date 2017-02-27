using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using WpfApplication1.Annotations;

namespace WpfApplication1.Panels
{
    /// <summary>
    /// Interaction logic for UnownScriptsPanel.xaml
    /// </summary>
    public partial class UnownScriptsPanel : UserControl, INotifyPropertyChanged
    {
        private Dictionary<string, string> _turnInCity;

        public UnownScriptsPanel()
        {
            InitializeComponent();
            DataContext = this;

            TurnInCity = new Dictionary<string, string>
            {
                {"Idyllshire", Properties.Resources.ResourceManager.GetString("Idyllshire")},
                {"MorDhona", Properties.Resources.ResourceManager.GetString("MorDhona")}
            };
        }

        public Dictionary<string, string> TurnInCity
        {
            get { return _turnInCity; }
            set
            {
                if (Equals(value, _turnInCity)) return;
                _turnInCity = value;
                OnPropertyChanged();
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
