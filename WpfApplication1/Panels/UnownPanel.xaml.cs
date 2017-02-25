using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using WpfApplication1.Model;
using WpfApplication1.Snorlax_Models;

namespace WpfApplication1.Panels
{
    /// <summary>
    /// Interaction logic for UnownPanel.xaml
    /// </summary>
    public partial class UnownPanel : UserControl, INotifyPropertyChanged
    {
        public Dictionary<string, string> Rotations { get; set; }

        private ObservableCollection<GatherableItem> _gatherableItems;
        public ObservableCollection<GatherableItem> GatherableItems
        {
            get { return _gatherableItems; }
            set
            {
                _gatherableItems = value;
                OnPropertyChanged("GatherableItems");
            }
        }

        private ObservableCollection<GatherableItem> _selectedGatherableItems;
        public ObservableCollection<GatherableItem> SelectedGatherableItems
        {
            get { return _selectedGatherableItems; }
            set
            {
                _selectedGatherableItems = value;
                OnPropertyChanged("SelectedGatherableItems");
            }
        }

        public UnownPanel()
        {
            InitializeComponent();
            DataContext = this;

            Rotations = new Dictionary<string, string>
            {
                {"Yield", "Récupération : +2 objets / +5% ou +15% de chance de récolter"},
                {"Quality", "Qualité : +30% de chance de HQ / +5% ou +15% de chance de récolter"},
                {"YieldAndQuality", "Qualité/Récupération : +2 objets / +10% de chance de HQ"}
            };

            GenerateGatherableItemsList();
            GenerateSelectedGatherableItemsList();
        }
        
        private void GenerateSelectedGatherableItemsList()
        {
            foreach (var gatherableItem in GatherableItems)
            {
                var isActive = (bool)EntraxModel.Instance.GetType().GetProperty(gatherableItem.PropertyName).GetValue(EntraxModel.Instance);
                if (!isActive) 
                    continue;

                if (gatherableItem.IsCollectable)
                {
                    var asCollectable = (bool)EntraxModel.Instance.GetType().GetProperty(gatherableItem.CollectablePropertyName).GetValue(EntraxModel.Instance);
                    gatherableItem.AsCollectable = asCollectable;
                }

                SelectedGatherableItems.Add(gatherableItem);
            }
        }

        private void GenerateGatherableItemsList()
        {
            GatherableItems = new ObservableCollection<GatherableItem>();
            SelectedGatherableItems = new ObservableCollection<GatherableItem>();

            ShowHideButton.Content = "Masquer";

            /* 1 - 13 */
            GatherableItems.Add(new GatherableItem { Name = "Agrégat", Job = Job.Botanist, FirstStartTime = 1, PropertyName = "Cluster_1AM" });
            GatherableItems.Add(new GatherableItem { Name = "Météorite", Job = Job.Miner, FirstStartTime = 1, PropertyName = "Meteorite" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de smithsonite", Job = Job.Miner, FirstStartTime = 1, PropertyName = "SmithsoniteOre" });
            GatherableItems.Add(new GatherableItem { Name = "Cocon de vers à soie", Job = Job.Botanist, FirstStartTime = 1, PropertyName = "SilkwormCocoon" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de sombracier", Job = Job.Miner, FirstStartTime = 1, PropertyName = "DarksteelOre" });

            GatherableItems.Add(new GatherableItem { Name = "Agrégat", Job = Job.Miner, FirstStartTime = 13, PropertyName = "Cluster_1PM" });
            GatherableItems.Add(new GatherableItem { Name = "Fleur de coton des neiges", Job = Job.Botanist, FirstStartTime = 13, PropertyName = "FrostCottonBoll" });
            GatherableItems.Add(new GatherableItem { Name = "Baie vampire", Job = Job.Botanist, FirstStartTime = 13, PropertyName = "VampirePlant" });

            /* 2 - 14 */
            GatherableItems.Add(new GatherableItem { Name = "Rondin odorant", Job = Job.Botanist, FirstStartTime = 2, PropertyName = "FragrantLog" });
            GatherableItems.Add(new GatherableItem { Name = "Roche antéombrale", Job = Job.Miner, FirstStartTime = 2, PropertyName = "AntumbralRock" });

            GatherableItems.Add(new GatherableItem { Name = "Truffe noire", Job = Job.Botanist, FirstStartTime = 14, PropertyName = "BlackTruffle" });
            GatherableItems.Add(new GatherableItem { Name = "Tomate Dzemael", Job = Job.Botanist, FirstStartTime = 14, PropertyName = "DzemaelTomato" });
            GatherableItems.Add(new GatherableItem { Name = "Graines de tomate Dzemael", Job = Job.Botanist, FirstStartTime = 14, PropertyName = "DzemaelTomatoSeeds" });

            GatherableItems.Add(new GatherableItem { Name = "Graines de figuier du vieux continent", Job = Job.Botanist, FirstStartTime = 2, SecondStartTime = 14, HasSecondStartTime = true, PropertyName = "OldWorldFigSeeds" });
            GatherableItems.Add(new GatherableItem { Name = "Figue du vieux continent", Job = Job.Botanist, FirstStartTime = 2, SecondStartTime = 14, HasSecondStartTime = true, IsCollectable = true, PropertyName = "OldWorldFig", CollectablePropertyName = "Collect_OldWorldFig" });
            GatherableItems.Add(new GatherableItem { Name = "Quartz jaune", Job = Job.Miner, FirstStartTime = 2, SecondStartTime = 14, HasSecondStartTime = true, IsCollectable = true, PropertyName = "YellowQuartz", CollectablePropertyName = "Collect_YellowQuartz" });
            GatherableItems.Add(new GatherableItem { Name = "Quartz vert", Job = Job.Miner, FirstStartTime = 2, SecondStartTime = 14, HasSecondStartTime = true, IsCollectable = true, PropertyName = "GreenQuartz", CollectablePropertyName = "Collect_GreenQuartz" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai d'hématite", Job = Job.Miner, FirstStartTime = 2, SecondStartTime = 14, HasSecondStartTime = true, IsCollectable = true, PropertyName = "LightKidneyOre", CollectablePropertyName = "Collect_LightKidneyOre" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de cuprite", Job = Job.Miner, FirstStartTime = 2, SecondStartTime = 14, HasSecondStartTime = true, IsCollectable = true, PropertyName = "Cuprite", CollectablePropertyName = "Collect_Cuprite" });

            /* 3 - 15 */
            GatherableItems.Add(new GatherableItem { Name = "Minerai de lumithrite", Job = Job.Miner, FirstStartTime = 2, PropertyName = "LumythriteOre" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de ferbérite", Job = Job.Miner, FirstStartTime = 2, PropertyName = "Ferberite" });
            GatherableItems.Add(new GatherableItem { Name = "Topaze brute", Job = Job.Miner, FirstStartTime = 2, PropertyName = "RawTopaz" });
            GatherableItems.Add(new GatherableItem { Name = "Cordiérite brute", Job = Job.Miner, FirstStartTime = 2, PropertyName = "RawIolite" });

            GatherableItems.Add(new GatherableItem { Name = "Vieux camphrier", Job = Job.Botanist, FirstStartTime = 14, PropertyName = "OldGrowthCamphorwoodLog" });
            GatherableItems.Add(new GatherableItem { Name = "Sève cristallisée", Job = Job.Miner, FirstStartTime = 14, PropertyName = "CrystallizedSap" });

            /* 4 - 16 */
            GatherableItems.Add(new GatherableItem { Name = "Minerai de platine", Job = Job.Miner, FirstStartTime = 4, PropertyName = "PlatinumOre" });
            GatherableItems.Add(new GatherableItem { Name = "Pépite d'or natif", Job = Job.Miner, FirstStartTime = 4, PropertyName = "NativeGold" });
            GatherableItems.Add(new GatherableItem { Name = "Diamant brut", Job = Job.Miner, FirstStartTime = 4, PropertyName = "RawDiamond" });
            GatherableItems.Add(new GatherableItem { Name = "Émeraude brute", Job = Job.Miner, FirstStartTime = 4, PropertyName = "RawEmerald" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de luminium", Job = Job.Miner, FirstStartTime = 4, PropertyName = "LuminiumOre" });

            GatherableItems.Add(new GatherableItem { Name = "Champignon brun", Job = Job.Botanist, FirstStartTime = 16, PropertyName = "BrownMushroom" });

            /* 5 - 17 */
            GatherableItems.Add(new GatherableItem { Name = "Agrégat", Job = Job.Botanist, FirstStartTime = 5, PropertyName = "Cluster_5AM" });
            GatherableItems.Add(new GatherableItem { Name = "Terreau thanalanais III", Job = Job.Miner, FirstStartTime = 5, PropertyName = "ThanalanTopsoil3" });
            GatherableItems.Add(new GatherableItem { Name = "Sable d\'or", Job = Job.Miner, FirstStartTime = 5, PropertyName = "GoldSand" });
            GatherableItems.Add(new GatherableItem { Name = "Rondin d\'ébène", Job = Job.Botanist, FirstStartTime = 5, PropertyName = "EbonyLog" });
            GatherableItems.Add(new GatherableItem { Name = "Trille", Job = Job.Botanist, FirstStartTime = 5, PropertyName = "Trillium" });
            GatherableItems.Add(new GatherableItem { Name = "Citron miel", Job = Job.Botanist, FirstStartTime = 5, PropertyName = "HoneyLemon" });
            GatherableItems.Add(new GatherableItem { Name = "Granulat astral", Job = Job.Miner, FirstStartTime = 5, IsCollectable = true, PropertyName = "AstralMoraine", CollectablePropertyName = "Collect_AstralMoraine" });
            GatherableItems.Add(new GatherableItem { Name = "Mica doré", Job = Job.Miner, FirstStartTime = 5, IsCollectable = true, PropertyName = "SunMica", CollectablePropertyName = "Collect_SunMica" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai d'aurum regis", Job = Job.Miner, FirstStartTime = 5, IsCollectable = true, PropertyName = "AurumRegisOre", CollectablePropertyName = "Collect_AurumRegisOre" });

            GatherableItems.Add(new GatherableItem { Name = "Gui de Thavnair", Job = Job.Botanist, FirstStartTime = 17, PropertyName = "ThavnairianMistletoe_5" });

            GatherableItems.Add(new GatherableItem { Name = "Sel gemme noscéen", Job = Job.Miner, FirstStartTime = 17, PropertyName = "VolcanicRockSalt_5" });
            GatherableItems.Add(new GatherableItem { Name = "Romarin", Job = Job.Botanist, FirstStartTime = 17, PropertyName = "Rosemary" });
            GatherableItems.Add(new GatherableItem { Name = "Agrégat", Job = Job.Miner, FirstStartTime = 17, PropertyName = "Cluster_5PM" });
            GatherableItems.Add(new GatherableItem { Name = "Gousse de vanille", Job = Job.Botanist, FirstStartTime = 17, IsCollectable = true, PropertyName = "VanillaBeans", CollectablePropertyName = "Collect_VanillaBeans" });
            GatherableItems.Add(new GatherableItem { Name = "Amandes mielleuses", Job = Job.Botanist, FirstStartTime = 17, IsCollectable = true, PropertyName = "HoneydewAlmonds", CollectablePropertyName = "Collect_HoneydewAlmonds" });
            GatherableItems.Add(new GatherableItem { Name = "Fleur astrale", Job = Job.Botanist, FirstStartTime = 17, IsCollectable = true, PropertyName = "SeventhHeaven", CollectablePropertyName = "Collect_SeventhHeaven" });

            /* 6 - 18 */
            GatherableItems.Add(new GatherableItem { Name = "Minerai de zéolite", Job = Job.Miner, FirstStartTime = 6, PropertyName = "ZeoliteOre" });

            GatherableItems.Add(new GatherableItem { Name = "Rubis brut", Job = Job.Miner, FirstStartTime = 18, PropertyName = "RawRuby" });
            GatherableItems.Add(new GatherableItem { Name = "Saphir brut", Job = Job.Miner, FirstStartTime = 18, PropertyName = "RawSapphire" });
            GatherableItems.Add(new GatherableItem { Name = "Rondin de teck", Job = Job.Botanist, FirstStartTime = 18, PropertyName = "Teaklog" });

            /* 7 - 19 */
            GatherableItems.Add(new GatherableItem { Name = "Roche ombrale", Job = Job.Miner, FirstStartTime = 7, PropertyName = "UmbralRock" });
            GatherableItems.Add(new GatherableItem { Name = "Rondin fragrant", Job = Job.Botanist, FirstStartTime = 7, PropertyName = "RedolentLog" });
            GatherableItems.Add(new GatherableItem { Name = "Terreau sombrelinçois III", Job = Job.Miner, FirstStartTime = 7, PropertyName = "ShroudTopsoil3" });
            GatherableItems.Add(new GatherableItem { Name = "Jeunes épinards des Cieldalaes", Job = Job.Botanist, FirstStartTime = 7, PropertyName = "YoungCieldalaesSpinach" });
            GatherableItems.Add(new GatherableItem { Name = "Quartz violet", Job = Job.Botanist, FirstStartTime = 7, PropertyName = "VioletQuartz" });
            GatherableItems.Add(new GatherableItem { Name = "Quartz bleu", Job = Job.Botanist, FirstStartTime = 7, PropertyName = "BlueQuartz" });
            GatherableItems.Add(new GatherableItem { Name = "Alun rouge", Job = Job.Botanist, FirstStartTime = 7, PropertyName = "RedAlumen" });

            GatherableItems.Add(new GatherableItem { Name = "Terreau noscéen III", Job = Job.Miner, FirstStartTime = 19, PropertyName = "LaNosceanTopsoil3" });
            GatherableItems.Add(new GatherableItem { Name = "Gui de Thavnair", Job = Job.Botanist, FirstStartTime = 19, PropertyName = "ThavnairianMistletoe_7" });
            GatherableItems.Add(new GatherableItem { Name = "Sel gemme noscéen", Job = Job.Miner, FirstStartTime = 19, PropertyName = "VolcanicRockSalt_7" });
            GatherableItems.Add(new GatherableItem { Name = "Premier œuf de basilic", Job = Job.Miner, FirstStartTime = 19, PropertyName = "VirginBasiliskEgg" });
            GatherableItems.Add(new GatherableItem { Name = "Paprika dravanien", Job = Job.Botanist, FirstStartTime = 19, PropertyName = "DravanianPaprika" });
            GatherableItems.Add(new GatherableItem { Name = "Écorce d'acacia", Job = Job.Botanist, FirstStartTime = 19, PropertyName = "WattleBark" });
            GatherableItems.Add(new GatherableItem { Name = "Lainuchairelle", Job = Job.Botanist, FirstStartTime = 19, PropertyName = "Snurbleberry" });

            /* 8 - 20 */
            GatherableItems.Add(new GatherableItem { Name = "Minerai de tungstite", Job = Job.Miner, FirstStartTime = 8, PropertyName = "Tungstite" });
            GatherableItems.Add(new GatherableItem { Name = "Poireau noscéen", Job = Job.Botanist, FirstStartTime = 8, PropertyName = "LaNosceanLeek" });
            GatherableItems.Add(new GatherableItem { Name = "Plume de sauvagine", Job = Job.Botanist, FirstStartTime = 8, PropertyName = "WaterfowlFeather" });

            GatherableItems.Add(new GatherableItem { Name = "Sauge noble", Job = Job.Botanist, FirstStartTime = 20, PropertyName = "NobleSage" });

            /* 9 - 21 */
            GatherableItems.Add(new GatherableItem { Name = "Agrégat", Job = Job.Botanist, FirstStartTime = 9, PropertyName = "Cluster_9AM" });
            GatherableItems.Add(new GatherableItem { Name = "Rondin d\'épicéa", Job = Job.Botanist, FirstStartTime = 9, PropertyName = "SpruceLog" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai d\'or", Job = Job.Miner, FirstStartTime = 9, PropertyName = "GoldOre" });
            GatherableItems.Add(new GatherableItem { Name = "Abricot", Job = Job.Botanist, FirstStartTime = 9, PropertyName = "Apricot" });
            GatherableItems.Add(new GatherableItem { Name = "Ananas épineux", Job = Job.Miner, FirstStartTime = 9, PropertyName = "PricklyPineapple" });
            GatherableItems.Add(new GatherableItem { Name = "Graines d\'ananas épineux", Job = Job.Miner, FirstStartTime = 9, PropertyName = "PricklyPineappleSeeds" });

            GatherableItems.Add(new GatherableItem { Name = "Agrégat", Job = Job.Miner, FirstStartTime = 21, PropertyName = "Cluster_9PM" });
            GatherableItems.Add(new GatherableItem { Name = "Mini-mini-mandragore", Job = Job.Botanist, FirstStartTime = 21, PropertyName = "Kidragora" });
            GatherableItems.Add(new GatherableItem { Name = "Bulbe de trille", Job = Job.Botanist, FirstStartTime = 21, PropertyName = "TrilliumBulb" });

            GatherableItems.Add(new GatherableItem { Name = "Légumes cabus", Job = Job.Botanist, FirstStartTime = 9, SecondStartTime = 21, HasSecondStartTime = true, IsCollectable = true, PropertyName = "Chysahl", CollectablePropertyName = "Collect_Chysahl" });

            /* 10 - 22 */
            GatherableItems.Add(new GatherableItem { Name = "Rondin de cyprès", Job = Job.Botanist, FirstStartTime = 10, PropertyName = "CypressLog" });

            GatherableItems.Add(new GatherableItem { Name = "Graines de chou-bourgeon", Job = Job.Botanist, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, PropertyName = "PearlSproutSeeds" });
            GatherableItems.Add(new GatherableItem { Name = "Graines de théier du Coerthas", Job = Job.Botanist, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, PropertyName = "CoerthanTeaSeeds" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de pyrite", Job = Job.Miner, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, IsCollectable = true, PropertyName = "Pyrite", CollectablePropertyName = "Collect_Pyrite" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de chalcocite", Job = Job.Miner, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, IsCollectable = true, PropertyName = "Chalcocite", CollectablePropertyName = "Collect_Chalcocite" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de limonite", Job = Job.Miner, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, IsCollectable = true, PropertyName = "Limonite", CollectablePropertyName = "Collect_Limonite" });
            GatherableItems.Add(new GatherableItem { Name = "Feuilles de thé du Coerthas", Job = Job.Botanist, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, IsCollectable = true, PropertyName = "CoerthanTeaLeaves", CollectablePropertyName = "Collect_CoerthanTeaLeaves" });
            GatherableItems.Add(new GatherableItem { Name = "Chou-bourgeon", Job = Job.Botanist, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, IsCollectable = true, PropertyName = "PearlSprouts", CollectablePropertyName = "Collect_PearlSprouts" });
            GatherableItems.Add(new GatherableItem { Name = "Ciboulette", Job = Job.Botanist, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, IsCollectable = true, PropertyName = "Chives", CollectablePropertyName = "Collect_Chives" });
            GatherableItems.Add(new GatherableItem { Name = "Citron céleste", Job = Job.Botanist, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, IsCollectable = true, PropertyName = "HeavensLemon", CollectablePropertyName = "Collect_HeavensLemon" });
            GatherableItems.Add(new GatherableItem { Name = "Gui d'Abalathia", Job = Job.Botanist, FirstStartTime = 10, SecondStartTime = 22, HasSecondStartTime = true, IsCollectable = true, PropertyName = "AbalathianMistletoe", CollectablePropertyName = "Collect_AbalathianMistletoe" });

            /* 11 - 23 */
            GatherableItems.Add(new GatherableItem { Name = "Minerai d\'adamant", Job = Job.Miner, FirstStartTime = 11, SecondStartTime = 23, HasSecondStartTime = true, IsCollectable = true, PropertyName = "Adamantite", CollectablePropertyName = "Collect_Adamantite" });

            /* 00 - 12 */
            GatherableItems.Add(new GatherableItem { Name = "Fleur de coton des étoiles", Job = Job.Botanist, FirstStartTime = 12, PropertyName = "StarCottonBoll" });

            GatherableItems.Add(new GatherableItem { Name = "Bolet", Job = Job.Botanist, FirstStartTime = 12, SecondStartTime = 0, HasSecondStartTime = true, IsCollectable = true, PropertyName = "Porcini", CollectablePropertyName = "Collect_Porcini" });
            GatherableItems.Add(new GatherableItem { Name = "Gui de Dravania", Job = Job.Botanist, FirstStartTime = 12, SecondStartTime = 0, HasSecondStartTime = true, IsCollectable = true, PropertyName = "DravanianMistletoe", CollectablePropertyName = "Collect_DravanianMistletoe" });
            GatherableItems.Add(new GatherableItem { Name = "Banane céleste", Job = Job.Botanist, FirstStartTime = 12, SecondStartTime = 0, HasSecondStartTime = true, IsCollectable = true, PropertyName = "CloudBanana", CollectablePropertyName = "Collect_CloudBanana" });
            GatherableItems.Add(new GatherableItem { Name = "Morille", Job = Job.Botanist, FirstStartTime = 12, SecondStartTime = 0, HasSecondStartTime = true, IsCollectable = true, PropertyName = "Morel", CollectablePropertyName = "Collect_Morel" });
            GatherableItems.Add(new GatherableItem { Name = "Sel gemme d\'Abalathia", Job = Job.Miner, FirstStartTime = 12, SecondStartTime = 0, HasSecondStartTime = true, IsCollectable = true, PropertyName = "AbalathianRockSalt", CollectablePropertyName = "Collect_AbalathianRockSalt" });
            GatherableItems.Add(new GatherableItem { Name = "Quartz rouge", Job = Job.Miner, FirstStartTime = 12, SecondStartTime = 0, HasSecondStartTime = true, IsCollectable = true, PropertyName = "RedQuartz", CollectablePropertyName = "Collect_RedQuartz" });

            GatherableItems = new ObservableCollection<GatherableItem>(GatherableItems.OrderBy(i => i.FirstStartTime).ThenBy(i => i.Name).ToList());
            ICollectionView view = CollectionViewSource.GetDefaultView(GatherableItems);
            view.GroupDescriptions.Add(new PropertyGroupDescription("GetTime"));
            ItemSelectionList.ItemsSource = view;
        }

        public void EventSetter_OnHandler(object sender, MouseButtonEventArgs e)
        {
            GatherableItem item = ItemSelectionList.SelectedItem as GatherableItem;
            if (item == null)
                return;

            if (SelectedGatherableItems.Any(gatherableItem => gatherableItem.Name.Equals(item.Name) && gatherableItem.Job == item.Job && gatherableItem.FirstStartTime == item.FirstStartTime))
            {
                return;
            }

            SelectedGatherableItems.Add(item);

            EntraxModel.Instance.GetType().GetProperty(item.PropertyName).SetValue(EntraxModel.Instance, true);

            SelectedGatherableItems = new ObservableCollection<GatherableItem>(SelectedGatherableItems.OrderBy(i => i.FirstStartTime).ThenBy(i => i.Name).ToList());
        }

        public void RemoveGatherableItem_OnClick(object sender, RoutedEventArgs e)
        {
            GatherableItem item = ((ListBoxItem)SelectedItemList.ContainerFromElement((Button)sender)).Content as GatherableItem;

            foreach (var selectedGatherableItem in SelectedGatherableItems.ToList())
            {
                if (selectedGatherableItem.Name.Equals(item.Name) && selectedGatherableItem.Job == item.Job)
                {
                    SelectedGatherableItems.Remove(selectedGatherableItem);
                    selectedGatherableItem.AsCollectable = false;
                    EntraxModel.Instance.GetType().GetProperty(item.PropertyName).SetValue(EntraxModel.Instance, false);
                }
            }
        }

        public void ShowHideButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (ItemSelectionList.Visibility == Visibility.Visible)
            {
                ItemSelectionList.Visibility = Visibility.Collapsed;
                ShowHideButton.Content = "Afficher";
            }
            else
            {
                ItemSelectionList.Visibility = Visibility.Visible;
                ShowHideButton.Content = "Masquer";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
