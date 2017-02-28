using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Data;
using WpfApplication1.Annotations;
using WpfApplication1.Model;
using WpfApplication1.Snorlax_Models;

namespace WpfApplication1.Panels
{
    /// <summary>
    /// Interaction logic for UnownScriptsPanel.xaml
    /// </summary>
    public partial class UnownScriptsPanel : UserControl, INotifyPropertyChanged
    {
        private Dictionary<string, string> _turnInCity;

        private string _redSearchText;
        public string RedSearchText
        {
            get { return _redSearchText; }
            set
            {
                _redSearchText = value;
                OnPropertyChanged("RedSearchText");
                UpdateRedSearchCriteria();
            }
        }

        private void UpdateRedSearchCriteria()
        {
            var view = CollectionViewSource.GetDefaultView(RedGatherableItems);
            if (!string.IsNullOrWhiteSpace(_redSearchText))
            {
                view.Filter = (o) => (o as GatherableItem).Name.ToLower().Contains(_redSearchText.ToLower());
            }
            else
            {
                view.Filter = null;
            }
        }

        private string _blueSearchText;
        public string BlueSearchText
        {
            get { return _blueSearchText; }
            set
            {
                _blueSearchText = value;
                OnPropertyChanged("BlueSearchText");
                UpdateBlueSearchCriteria();
            }
        }

        private void UpdateBlueSearchCriteria()
        {
            var view = CollectionViewSource.GetDefaultView(BlueGatherableItems);
            if (!string.IsNullOrWhiteSpace(_blueSearchText))
            {
                view.Filter = (o) => (o as GatherableItem).Name.ToLower().Contains(_blueSearchText.ToLower());
            }
            else
            {
                view.Filter = null;
            }
        }

        private ObservableCollection<GatherableItem> _redGatherableItems;
        public ObservableCollection<GatherableItem> RedGatherableItems
        {
            get { return _redGatherableItems; }
            set
            {
                _redGatherableItems = value;
                OnPropertyChanged("RedGatherableItems");
            }
        }

        private ObservableCollection<GatherableItem> _blueGatherableItems;
        public ObservableCollection<GatherableItem> BlueGatherableItems
        {
            get { return _blueGatherableItems; }
            set
            {
                _blueGatherableItems = value;
                OnPropertyChanged("BlueGatherableItems");
            }
        }

        public UnownScriptsPanel()
        {
            InitializeComponent();
            DataContext = this;

            TurnInCity = new Dictionary<string, string>
            {
                {"Idyllshire", Properties.Resources.ResourceManager.GetString("Idyllshire")},
                {"MorDhona", Properties.Resources.ResourceManager.GetString("MorDhona")}
            };

            BlueGatherableItems = new ObservableCollection<GatherableItem>();
            RedGatherableItems = new ObservableCollection<GatherableItem>();
            GenerateBlueGatherableItems();
            GenerateRedGatherableItems();
        }

        private void GenerateRedGatherableItems()
        {
            RedGatherableItems.Add(new GatherableItem { PropertyName = "RedGatherToken", Quantity = EntraxModel.Instance.RedGatherToken });
            RedGatherableItems.Add(new GatherableItem { PropertyName = "GoblinDice", Quantity = EntraxModel.Instance.GoblinDice });
            RedGatherableItems.Add(new GatherableItem { PropertyName = "GuerdonIV", Quantity = EntraxModel.Instance.GuerdonIV });
            RedGatherableItems.Add(new GatherableItem { PropertyName = "GuileIV", Quantity = EntraxModel.Instance.GuileIV });
            RedGatherableItems.Add(new GatherableItem { PropertyName = "GraspIV", Quantity = EntraxModel.Instance.GraspIV });

            RedGatherableItems = new ObservableCollection<GatherableItem>(RedGatherableItems.OrderBy(i => i.Name).ToList());

            ICollectionView view = CollectionViewSource.GetDefaultView(RedGatherableItems);
            RedItemSelectionList.ItemsSource = view;
        }

        private void GenerateBlueGatherableItems()
        {
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "BlueGatherToken", Quantity = EntraxModel.Instance.BlueGatherToken });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "HiCordial", Quantity = EntraxModel.Instance.HiCordial });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "BruteLeech", Quantity = EntraxModel.Instance.BruteLeech });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "CraneFly", Quantity = EntraxModel.Instance.CraneFly });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "CommercialSurvivalManual", Quantity = EntraxModel.Instance.CommercialSurvivalManual });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "TrailblazersScarf", Quantity = EntraxModel.Instance.TrailblazersScarf });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "TrailblazersVest", Quantity = EntraxModel.Instance.TrailblazersVest });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "TrailblazersWristguards", Quantity = EntraxModel.Instance.TrailblazersWristguards });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "TrailblazersSlops", Quantity = EntraxModel.Instance.TrailblazersSlops });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "TrailblazersShoes", Quantity = EntraxModel.Instance.TrailblazersShoes });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "FiendWorm", Quantity = EntraxModel.Instance.FiendWorm });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "MagmaWorm", Quantity = EntraxModel.Instance.MagmaWorm });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "RedBalloon", Quantity = EntraxModel.Instance.RedBalloon });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "CrownTrout", Quantity = EntraxModel.Instance.CrownTrout });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "CrownTroutHQ", Quantity = EntraxModel.Instance.CrownTroutHQ });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "RetributionStaff", Quantity = EntraxModel.Instance.RetributionStaff });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "RetributionStaffHQ", Quantity = EntraxModel.Instance.RetributionStaffHQ });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "ThiefBetta", Quantity = EntraxModel.Instance.ThiefBetta });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "ThiefBettaHQ", Quantity = EntraxModel.Instance.ThiefBettaHQ });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "GoldsmithCrab", Quantity = EntraxModel.Instance.GoldsmithCrab });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "GoldsmithCrabHQ", Quantity = EntraxModel.Instance.GoldsmithCrabHQ });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "Pterodactyl", Quantity = EntraxModel.Instance.Pterodactyl });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "PterodactylHQ", Quantity = EntraxModel.Instance.PterodactylHQ });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "Eurhinosaur", Quantity = EntraxModel.Instance.Eurhinosaur });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "EurhinosaurHQ", Quantity = EntraxModel.Instance.EurhinosaurHQ });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "GemMarimo", Quantity = EntraxModel.Instance.GemMarimo });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "GemMarimoHQ", Quantity = EntraxModel.Instance.GemMarimoHQ });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "Sphalerite", Quantity = EntraxModel.Instance.Sphalerite });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "SphaleriteHQ", Quantity = EntraxModel.Instance.SphaleriteHQ });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "WindSilk", Quantity = EntraxModel.Instance.WindSilk });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "CloudCottonBoll", Quantity = EntraxModel.Instance.CloudCottonBoll });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "CloudCottonBollHQ", Quantity = EntraxModel.Instance.CloudCottonBollHQ });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "DinosaurLeather", Quantity = EntraxModel.Instance.DinosaurLeather });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "RoyalMistletoe", Quantity = EntraxModel.Instance.RoyalMistletoe });
            BlueGatherableItems.Add(new GatherableItem { PropertyName = "RoyalMistletoeHQ", Quantity = EntraxModel.Instance.RoyalMistletoeHQ });

            BlueGatherableItems = new ObservableCollection<GatherableItem>(BlueGatherableItems.OrderBy(i => i.Name).ToList());

            ICollectionView view = CollectionViewSource.GetDefaultView(BlueGatherableItems);
            BlueItemSelectionList.ItemsSource = view;
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
