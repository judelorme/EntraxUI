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
    /// Interaction logic for SnorlaxPanel.xaml
    /// </summary>
    public partial class SnorlaxPanel : UserControl, INotifyPropertyChanged
    {
        public Dictionary<string, string> Rotations { get; set; }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged("SearchText");
                UpdateSearchCriteria();
            }
        }

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

        public SnorlaxPanel()
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

        public void UpdateSearchCriteria()
        {
            var view = CollectionViewSource.GetDefaultView(GatherableItems);
            if (!string.IsNullOrWhiteSpace(_searchText))
            {
                view.Filter = (o) => (o as GatherableItem).Name.ToLower().Contains(_searchText.ToLower());
            }
            else
            {
                view.Filter = null;
            }
        }

        private void GenerateSelectedGatherableItemsList()
        {
            // MINER
            if (EntraxModel.Instance.RawCitrine > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Citrine brute", Job = Job.Miner, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.RawCitrine, PropertyName = "RawCitrine" });
            if (EntraxModel.Instance.IceCrystal_RedRime > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de glace", Job = Job.Miner, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.IceCrystal_RedRime, PropertyName = "IceCrystal_RedRime" });

            if (EntraxModel.Instance.AbalathianSpringWater > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Eau de source d'Abalathia", Job = Job.Miner, Localisation = "The Sea Of Clouds", Quantity = EntraxModel.Instance.AbalathianSpringWater, PropertyName = "AbalathianSpringWater" });
            if (EntraxModel.Instance.AurumRegisSand > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Sable d'aurum regis", Job = Job.Miner, Localisation = "The Sea Of Clouds", Quantity = EntraxModel.Instance.AurumRegisSand, PropertyName = "AurumRegisSand" });
            if (EntraxModel.Instance.LightningCrystal_VoorSianSiran_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de foudre", Job = Job.Miner, Localisation = "The Sea Of Clouds", Quantity = EntraxModel.Instance.LightningCrystal_VoorSianSiran_MIN, PropertyName = "LightningCrystal_VoorSianSiran_MIN" });
            if (EntraxModel.Instance.WaterCrystal_VoorSianSiran_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal d'eau", Job = Job.Miner, Localisation = "The Sea Of Clouds", Quantity = EntraxModel.Instance.WaterCrystal_VoorSianSiran_MIN, PropertyName = "WaterCrystal_VoorSianSiran_MIN" });

            if (EntraxModel.Instance.BeastkinHorn > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Corne de bête", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.BeastkinHorn, PropertyName = "BeastkinHorn" });
            if (EntraxModel.Instance.RawCarnelian > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cornaline brute", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.RawCarnelian, PropertyName = "RawCarnelian" });
            if (EntraxModel.Instance.RawOpal > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Opale brute", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.RawOpal, PropertyName = "RawOpal" });
            if (EntraxModel.Instance.FireCrystal_AvaloniaFallen_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de feu", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.FireCrystal_AvaloniaFallen_MIN, PropertyName = "FireCrystal_AvaloniaFallen_MIN" });

            if (EntraxModel.Instance.LumythriteSand > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Sable de lumithrite", Job = Job.Miner, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.LumythriteSand, PropertyName = "LumythriteSand" });
            if (EntraxModel.Instance.CloudMica > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Mica blanc", Job = Job.Miner, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.CloudMica, PropertyName = "CloudMica" });
            if (EntraxModel.Instance.HardsilverSand > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Sable de durargent", Job = Job.Miner, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.HardsilverSand, PropertyName = "HardsilverSand" });
            if (EntraxModel.Instance.EarthCrystal_LandlordColony_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de terre", Job = Job.Miner, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.EarthCrystal_LandlordColony_MIN, PropertyName = "EarthCrystal_LandlordColony_MIN" });

            if (EntraxModel.Instance.HardsilverOre > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Minerai de durargent", Job = Job.Miner, Localisation = "The Dravanian Hinterlands", Quantity = EntraxModel.Instance.HardsilverOre, PropertyName = "HardsilverOre" });
            if (EntraxModel.Instance.RawChrysolite > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Chrysolite brute", Job = Job.Miner, Localisation = "The Dravanian Hinterlands", Quantity = EntraxModel.Instance.RawChrysolite, PropertyName = "RawChrysolite" });
            if (EntraxModel.Instance.WyrmObsidian > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat d'obsidienne de wyrm", Job = Job.Miner, Localisation = "The Dravanian Hinterlands", Quantity = EntraxModel.Instance.WyrmObsidian, PropertyName = "WyrmObsidian" });
            if (EntraxModel.Instance.WindCrystal_TheMakersQuarter > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de vent", Job = Job.Miner, Localisation = "The Dravanian Hinterlands", Quantity = EntraxModel.Instance.WindCrystal_TheMakersQuarter, PropertyName = "WindCrystal_TheMakersQuarter" });

            if (EntraxModel.Instance.MythriteSand > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Sable de mithrite", Job = Job.Miner, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.MythriteSand, PropertyName = "MythriteSand" });
            if (EntraxModel.Instance.IceCrystal_Twinpools_MIN51 > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de glace", Job = Job.Miner, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.IceCrystal_Twinpools_MIN51, PropertyName = "IceCrystal_Twinpools_MIN51" });
            if (EntraxModel.Instance.MythriteOre > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Minerai de mithrite", Job = Job.Miner, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.MythriteOre, PropertyName = "MythriteOre" });
            if (EntraxModel.Instance.RawLarimar > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Larimar brut", Job = Job.Miner, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.RawLarimar, PropertyName = "RawLarimar" });
            if (EntraxModel.Instance.RawMormorion > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Mormorion brut", Job = Job.Miner, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.RawMormorion, PropertyName = "RawMormorion" });

            if (EntraxModel.Instance.RawAgate > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Agate brute", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.RawAgate, PropertyName = "RawAgate" });
            if (EntraxModel.Instance.RawTigersEye > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Oeil-de-tigre brut", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.RawTigersEye, PropertyName = "RawTigersEye" });
            if (EntraxModel.Instance.DravanianSpringWater > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Eau de source de Dravania", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.DravanianSpringWater, PropertyName = "DravanianSpringWater" });
            if (EntraxModel.Instance.FireCrystal_TheSmolderingWastes_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de feu", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.FireCrystal_TheSmolderingWastes_MIN, PropertyName = "FireCrystal_TheSmolderingWastes_MIN" });
            if (EntraxModel.Instance.TitaniumOre > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Minerai de titane", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.TitaniumOre, PropertyName = "TitaniumOre" });
            if (EntraxModel.Instance.RawStarRuby > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Rubis étoilé brut", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.RawStarRuby, PropertyName = "RawStarRuby" });
            if (EntraxModel.Instance.RawStarSapphire > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Saphir étoilé brut", Job = Job.Miner, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.RawStarSapphire, PropertyName = "RawStarSapphire" });

            if (EntraxModel.Instance.DragonObsidian > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat d'obsidienne de dragon", Job = Job.Miner, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.DragonObsidian, PropertyName = "DragonObsidian" });

            if (EntraxModel.Instance.CobaltOre > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Minerai de cobalt", Job = Job.Miner, Localisation = "Northern Thanalan", Quantity = EntraxModel.Instance.CobaltOre, PropertyName = "CobaltOre" });
            if (EntraxModel.Instance.BasiliskEgg > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Oeuf de basilic", Job = Job.Miner, Localisation = "Northern Thanalan", Quantity = EntraxModel.Instance.BasiliskEgg, PropertyName = "BasiliskEgg" });
            if (EntraxModel.Instance.ElectrumOre > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Minerai d'électrum", Job = Job.Miner, Localisation = "Upper La Noscea", Quantity = EntraxModel.Instance.ElectrumOre, PropertyName = "ElectrumOre" });
            if (EntraxModel.Instance.MythrilOre > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Minerai de mithril", Job = Job.Miner, Localisation = "Southern Thanalan", Quantity = EntraxModel.Instance.MythrilOre, PropertyName = "MythrilOre" });
            if (EntraxModel.Instance.SilverOre > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Minerai d'argent", Job = Job.Miner, Localisation = "South Shroud", Quantity = EntraxModel.Instance.SilverOre, PropertyName = "SilverOre" });
            if (EntraxModel.Instance.EffervescentWater > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Eau effervescente", Job = Job.Miner, Localisation = "South Shroud", Quantity = EntraxModel.Instance.EffervescentWater, PropertyName = "EffervescentWater" });

            if (EntraxModel.Instance.FireShard_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de feu", Job = Job.Miner, Localisation = "", Quantity = EntraxModel.Instance.FireShard_MIN, PropertyName = "FireShard_MIN" });
            if (EntraxModel.Instance.IceShard_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de glace", Job = Job.Miner, Localisation = "", Quantity = EntraxModel.Instance.IceShard_MIN, PropertyName = "IceShard_MIN" });
            if (EntraxModel.Instance.WindShard_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de vent", Job = Job.Miner, Localisation = "", Quantity = EntraxModel.Instance.WindShard_MIN, PropertyName = "WindShard_MIN" });
            if (EntraxModel.Instance.EarthShard_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de terre", Job = Job.Miner, Localisation = "", Quantity = EntraxModel.Instance.EarthShard_MIN, PropertyName = "EarthShard_MIN" });
            if (EntraxModel.Instance.LightningShard_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de foudre", Job = Job.Miner, Localisation = "", Quantity = EntraxModel.Instance.LightningShard_MIN, PropertyName = "LightningShard_MIN" });
            if (EntraxModel.Instance.WaterShard_MIN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat d'eau", Job = Job.Miner, Localisation = "", Quantity = EntraxModel.Instance.WaterShard_MIN, PropertyName = "WaterShard_MIN" });

            // BOTANIST
            if (EntraxModel.Instance.WhitefrostCottonBoll > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Fleur de coton du givre", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.WhitefrostCottonBoll, PropertyName = "WhitefrostCottonBoll" });
            if (EntraxModel.Instance.Coriander > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Coriandre", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.Coriander, PropertyName = "Coriander" });
            if (EntraxModel.Instance.Rue > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Rue des jardins", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.Rue, PropertyName = "Rue" });
            if (EntraxModel.Instance.IceCrystal_Twinpools_BTN56 > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de glace", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.IceCrystal_Twinpools_BTN56, PropertyName = "IceCrystal_Twinpools_BTN56" });

            if (EntraxModel.Instance.BirchLog > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Rondin de bouleau", Job = Job.Botanist, Localisation = "The Sea Of Clouds", Quantity = EntraxModel.Instance.BirchLog, PropertyName = "BirchLog" });
            if (EntraxModel.Instance.BirchBranch > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Branche de bouleau", Job = Job.Botanist, Localisation = "The Sea Of Clouds", Quantity = EntraxModel.Instance.BirchBranch, PropertyName = "BirchBranch" });
            if (EntraxModel.Instance.BirchSap > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Sève de bouleau", Job = Job.Botanist, Localisation = "The Sea Of Clouds", Quantity = EntraxModel.Instance.BirchSap, PropertyName = "BirchSap" });
            if (EntraxModel.Instance.WaterCrystal_VoorSianSiran_BTN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal d'eau", Job = Job.Botanist, Localisation = "The Sea Of Clouds", Quantity = EntraxModel.Instance.WaterCrystal_VoorSianSiran_BTN, PropertyName = "WaterCrystal_VoorSianSiran_BTN" });

            if (EntraxModel.Instance.Coneflower > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Échinacée", Job = Job.Botanist, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.Coneflower, PropertyName = "Coneflower" });
            if (EntraxModel.Instance.FireCrystal_AvaloniaFallen_BTN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de feu", Job = Job.Botanist, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.FireCrystal_AvaloniaFallen_BTN, PropertyName = "FireCrystal_AvaloniaFallen_BTN" });

            if (EntraxModel.Instance.CamphorwoodBranch > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Branche de camphrier", Job = Job.Botanist, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.CamphorwoodBranch, PropertyName = "CamphorwoodBranch" });
            if (EntraxModel.Instance.CamphorwoodLog > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Rondin de camphrier", Job = Job.Botanist, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.CamphorwoodLog, PropertyName = "CamphorwoodLog" });
            if (EntraxModel.Instance.Dandelion > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Pissenlit", Job = Job.Botanist, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.Dandelion, PropertyName = "Dandelion" });
            if (EntraxModel.Instance.EarthCrystal_FourArms > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de terre", Job = Job.Botanist, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.EarthCrystal_FourArms, PropertyName = "EarthCrystal_FourArms" });

            if (EntraxModel.Instance.CowBitter > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Tanaisie", Job = Job.Botanist, Localisation = "The Dravanian Hinterlands", Quantity = EntraxModel.Instance.CowBitter, PropertyName = "CowBitter" });
            if (EntraxModel.Instance.Gaelicatnip > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cataire", Job = Job.Botanist, Localisation = "The Dravanian Hinterlands", Quantity = EntraxModel.Instance.Gaelicatnip, PropertyName = "Gaelicatnip" });
            if (EntraxModel.Instance.WindCrystal_TheAnsweringQuarter > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de vent", Job = Job.Botanist, Localisation = "The Dravanian Hinterlands", Quantity = EntraxModel.Instance.WindCrystal_TheAnsweringQuarter, PropertyName = "WindCrystal_TheAnsweringQuarter" });

            if (EntraxModel.Instance.RainbowCottonBoll > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Fleur de coton arc-en-ciel", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.RainbowCottonBoll, PropertyName = "RainbowCottonBoll" });
            if (EntraxModel.Instance.SprigOfMistDill > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Aneth", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.SprigOfMistDill, PropertyName = "SprigOfMistDill" });

            if (EntraxModel.Instance.DarkChestnut > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Marron sombre", Job = Job.Botanist, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.DarkChestnut, PropertyName = "DarkChestnut" });
            if (EntraxModel.Instance.DarkChestnutLog > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Rondin de châtaignier sombre", Job = Job.Botanist, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.DarkChestnutLog, PropertyName = "DarkChestnutLog" });
            if (EntraxModel.Instance.DarkChestnutBranch > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Branche de châtaignier sombre", Job = Job.Botanist, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.DarkChestnutBranch, PropertyName = "DarkChestnutBranch" });
            if (EntraxModel.Instance.CyclopsOnion > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Échalion cyclope", Job = Job.Botanist, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.CyclopsOnion, PropertyName = "CyclopsOnion" });
            if (EntraxModel.Instance.HighlandWheat > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Blé des hautes terres", Job = Job.Botanist, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.HighlandWheat, PropertyName = "HighlandWheat" });
            if (EntraxModel.Instance.StalkOfRamie > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Tige de ramie", Job = Job.Botanist, Localisation = "The Dravanian Forelands", Quantity = EntraxModel.Instance.StalkOfRamie, PropertyName = "StalkOfRamie" });

            if (EntraxModel.Instance.EmeraldBeans > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Haricots émeraude", Job = Job.Botanist, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.EmeraldBeans, PropertyName = "EmeraldBeans" });
            if (EntraxModel.Instance.MagmaBeet > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Betteraves de magma", Job = Job.Botanist, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.MagmaBeet, PropertyName = "MagmaBeet" });
            if (EntraxModel.Instance.EarthCrystal_LandlordColony_BTN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Cristal de terre", Job = Job.Botanist, Localisation = "The Churning Mists", Quantity = EntraxModel.Instance.EarthCrystal_LandlordColony_BTN, PropertyName = "EarthCrystal_LandlordColony_BTN" });
            if (EntraxModel.Instance.CedarLog > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Rondin de cèdre", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.CedarLog, PropertyName = "CedarLog" });
            if (EntraxModel.Instance.CedarBranch > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Branche de cèdre", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", Quantity = EntraxModel.Instance.CedarBranch, PropertyName = "CedarBranch" });

            if (EntraxModel.Instance.BloodCurrants > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Groseille sanguine", Job = Job.Botanist, Localisation = "South Shroud", Quantity = EntraxModel.Instance.BloodCurrants, PropertyName = "BloodCurrants" });
            if (EntraxModel.Instance.WhiteTruffle > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Truffe blanche", Job = Job.Botanist, Localisation = "South Shroud", Quantity = EntraxModel.Instance.WhiteTruffle, PropertyName = "WhiteTruffle" });
            if (EntraxModel.Instance.Aloe > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Aloès", Job = Job.Botanist, Localisation = "Southern Thanalan", Quantity = EntraxModel.Instance.Aloe, PropertyName = "Aloe" });
            if (EntraxModel.Instance.Flax > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Fibres de lin", Job = Job.Botanist, Localisation = "South Shroud", Quantity = EntraxModel.Instance.Flax, PropertyName = "Flax" });
            if (EntraxModel.Instance.HighlandParsley > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Persil hyurgoth", Job = Job.Botanist, Localisation = "Lower La Noscea", Quantity = EntraxModel.Instance.HighlandParsley, PropertyName = "HighlandParsley" });


            if (EntraxModel.Instance.FireShard_BTN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de feu", Job = Job.Botanist, Localisation = "", Quantity = EntraxModel.Instance.FireShard_BTN, PropertyName = "FireShard_BTN" });
            if (EntraxModel.Instance.IceShard_BTN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de glace", Job = Job.Botanist, Localisation = "", Quantity = EntraxModel.Instance.IceShard_BTN, PropertyName = "IceShard_BTN" });
            if (EntraxModel.Instance.WindShard_BTN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de vent", Job = Job.Botanist, Localisation = "", Quantity = EntraxModel.Instance.WindShard_BTN, PropertyName = "WindShard_BTN" });
            if (EntraxModel.Instance.EarthShard_BTN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de terre", Job = Job.Botanist, Localisation = "", Quantity = EntraxModel.Instance.EarthShard_BTN, PropertyName = "EarthShard_BTN" });
            if (EntraxModel.Instance.LightningShard_BTN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat de foudre", Job = Job.Botanist, Localisation = "", Quantity = EntraxModel.Instance.LightningShard_BTN, PropertyName = "LightningShard_BTN" });
            if (EntraxModel.Instance.WaterShard_BTN > 0)
                SelectedGatherableItems.Add(new GatherableItem { Name = "Éclat d'eau", Job = Job.Botanist, Localisation = "", Quantity = EntraxModel.Instance.WaterShard_BTN, PropertyName = "WaterShard_BTN" });
        }

        private void GenerateGatherableItemsList()
        {
            GatherableItems = new ObservableCollection<GatherableItem>();
            SelectedGatherableItems = new ObservableCollection<GatherableItem>();

            ShowHideButton.Content = "Masquer";

            /* MINER */
            GatherableItems.Add(new GatherableItem { Name = "Citrine brute", Job = Job.Miner, Localisation = "Coerthas Western Highlands", PropertyName = "RawCitrine" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de glace", Job = Job.Miner, Localisation = "Coerthas Western Highlands", PropertyName = "IceCrystal_RedRime" });

            GatherableItems.Add(new GatherableItem { Name = "Eau de source d'Abalathia", Job = Job.Miner, Localisation = "The Sea Of Clouds", PropertyName = "AbalathianSpringWater" });
            GatherableItems.Add(new GatherableItem { Name = "Sable d'aurum regis", Job = Job.Miner, Localisation = "The Sea Of Clouds", PropertyName = "AurumRegisSand" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de foudre", Job = Job.Miner, Localisation = "The Sea Of Clouds", PropertyName = "LightningCrystal_VoorSianSiran_MIN" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal d'eau", Job = Job.Miner, Localisation = "The Sea Of Clouds", PropertyName = "WaterCrystal_VoorSianSiran_MIN" });

            GatherableItems.Add(new GatherableItem { Name = "Corne de bête", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "BeastkinHorn" });
            GatherableItems.Add(new GatherableItem { Name = "Cornaline brute", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "RawCarnelian" });
            GatherableItems.Add(new GatherableItem { Name = "Opale brute", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "RawOpal" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de feu", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "FireCrystal_AvaloniaFallen_MIN" });

            GatherableItems.Add(new GatherableItem { Name = "Sable de lumithrite", Job = Job.Miner, Localisation = "The Churning Mists", PropertyName = "LumythriteSand" });
            GatherableItems.Add(new GatherableItem { Name = "Mica blanc", Job = Job.Miner, Localisation = "The Churning Mists", PropertyName = "CloudMica" });
            GatherableItems.Add(new GatherableItem { Name = "Sable de durargent", Job = Job.Miner, Localisation = "The Churning Mists", PropertyName = "HardsilverSand" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de terre", Job = Job.Miner, Localisation = "The Churning Mists", PropertyName = "EarthCrystal_LandlordColony_MIN" });

            GatherableItems.Add(new GatherableItem { Name = "Minerai de durargent", Job = Job.Miner, Localisation = "The Dravanian Hinterlands", PropertyName = "HardsilverOre" });
            GatherableItems.Add(new GatherableItem { Name = "Chrysolite brute", Job = Job.Miner, Localisation = "The Dravanian Hinterlands", PropertyName = "RawChrysolite" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat d'obsidienne de wyrm", Job = Job.Miner, Localisation = "The Dravanian Hinterlands", PropertyName = "WyrmObsidian" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de vent", Job = Job.Miner, Localisation = "The Dravanian Hinterlands", PropertyName = "WindCrystal_TheMakersQuarter" });

            GatherableItems.Add(new GatherableItem { Name = "Sable de mithrite", Job = Job.Miner, Localisation = "Coerthas Western Highlands", PropertyName = "MythriteSand" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de glace", Job = Job.Miner, Localisation = "Coerthas Western Highlands", PropertyName = "IceCrystal_Twinpools_MIN51" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de mithrite", Job = Job.Miner, Localisation = "Coerthas Western Highlands", PropertyName = "MythriteOre" });
            GatherableItems.Add(new GatherableItem { Name = "Larimar brut", Job = Job.Miner, Localisation = "Coerthas Western Highlands", PropertyName = "RawLarimar" });
            GatherableItems.Add(new GatherableItem { Name = "Mormorion brut", Job = Job.Miner, Localisation = "Coerthas Western Highlands", PropertyName = "RawMormorion" });

            GatherableItems.Add(new GatherableItem { Name = "Agate brute", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "RawAgate" });
            GatherableItems.Add(new GatherableItem { Name = "Oeil-de-tigre brut", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "RawTigersEye" });
            GatherableItems.Add(new GatherableItem { Name = "Eau de source de Dravania", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "DravanianSpringWater" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de feu", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "FireCrystal_TheSmolderingWastes_MIN" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de titane", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "TitaniumOre" });
            GatherableItems.Add(new GatherableItem { Name = "Rubis étoilé brut", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "RawStarRuby" });
            GatherableItems.Add(new GatherableItem { Name = "Saphir étoilé brut", Job = Job.Miner, Localisation = "The Dravanian Forelands", PropertyName = "RawStarSapphire" });

            GatherableItems.Add(new GatherableItem { Name = "Éclat d'obsidienne de dragon", Job = Job.Miner, Localisation = "Coerthas Western Highlands", PropertyName = "DragonObsidian" });

            GatherableItems.Add(new GatherableItem { Name = "Minerai de cobalt", Job = Job.Miner, Localisation = "Northern Thanalan", PropertyName = "CobaltOre" });
            GatherableItems.Add(new GatherableItem { Name = "Oeuf de basilic", Job = Job.Miner, Localisation = "Northern Thanalan", PropertyName = "BasiliskEgg" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai d'électrum", Job = Job.Miner, Localisation = "Upper La Noscea", PropertyName = "ElectrumOre" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai de mithril", Job = Job.Miner, Localisation = "Southern Thanalan", PropertyName = "MythrilOre" });
            GatherableItems.Add(new GatherableItem { Name = "Minerai d'argent", Job = Job.Miner, Localisation = "South Shroud", PropertyName = "SilverOre" });
            GatherableItems.Add(new GatherableItem { Name = "Eau effervescente", Job = Job.Miner, Localisation = "South Shroud", PropertyName = "EffervescentWater" });

            GatherableItems.Add(new GatherableItem { Name = "Éclat de feu", Job = Job.Miner, Localisation = "", PropertyName = "FireShard_MIN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat de glace", Job = Job.Miner, Localisation = "", PropertyName = "IceShard_MIN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat de vent", Job = Job.Miner, Localisation = "", PropertyName = "WindShard_MIN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat de terre", Job = Job.Miner, Localisation = "", PropertyName = "EarthShard_MIN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat de foudre", Job = Job.Miner, Localisation = "", PropertyName = "LightningShard_MIN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat d'eau", Job = Job.Miner, Localisation = "", PropertyName = "WaterShard_MIN" });

            /* BOTANIST */
            GatherableItems.Add(new GatherableItem { Name = "Fleur de coton du givre", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", PropertyName = "WhitefrostCottonBoll" });
            GatherableItems.Add(new GatherableItem { Name = "Coriandre", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", PropertyName = "Coriander" });
            GatherableItems.Add(new GatherableItem { Name = "Rue des jardins", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", PropertyName = "Rue" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de glace", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", PropertyName = "IceCrystal_Twinpools_BTN56" });

            GatherableItems.Add(new GatherableItem { Name = "Rondin de bouleau", Job = Job.Botanist, Localisation = "The Sea Of Clouds", PropertyName = "BirchLog" });
            GatherableItems.Add(new GatherableItem { Name = "Branche de bouleau", Job = Job.Botanist, Localisation = "The Sea Of Clouds", PropertyName = "BirchBranch" });
            GatherableItems.Add(new GatherableItem { Name = "Sève de bouleau", Job = Job.Botanist, Localisation = "The Sea Of Clouds", PropertyName = "BirchSap" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal d'eau", Job = Job.Botanist, Localisation = "The Sea Of Clouds", PropertyName = "WaterCrystal_VoorSianSiran_BTN" });

            GatherableItems.Add(new GatherableItem { Name = "Échinacée", Job = Job.Botanist, Localisation = "The Dravanian Forelands", PropertyName = "Coneflower" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de feu", Job = Job.Botanist, Localisation = "The Dravanian Forelands", PropertyName = "FireCrystal_AvaloniaFallen_BTN" });

            GatherableItems.Add(new GatherableItem { Name = "Branche de camphrier", Job = Job.Botanist, Localisation = "The Churning Mists", PropertyName = "CamphorwoodBranch" });
            GatherableItems.Add(new GatherableItem { Name = "Rondin de camphrier", Job = Job.Botanist, Localisation = "The Churning Mists", PropertyName = "CamphorwoodLog" });
            GatherableItems.Add(new GatherableItem { Name = "Pissenlit", Job = Job.Botanist, Localisation = "The Churning Mists", PropertyName = "Dandelion" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de terre", Job = Job.Botanist, Localisation = "The Churning Mists", PropertyName = "EarthCrystal_FourArms" });

            GatherableItems.Add(new GatherableItem { Name = "Tanaisie", Job = Job.Botanist, Localisation = "The Dravanian Hinterlands", PropertyName = "CowBitter" });
            GatherableItems.Add(new GatherableItem { Name = "Cataire", Job = Job.Botanist, Localisation = "The Dravanian Hinterlands", PropertyName = "Gaelicatnip" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de vent", Job = Job.Botanist, Localisation = "The Dravanian Hinterlands", PropertyName = "WindCrystal_TheAnsweringQuarter" });

            GatherableItems.Add(new GatherableItem { Name = "Fleur de coton arc-en-ciel", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", PropertyName = "RainbowCottonBoll" });
            GatherableItems.Add(new GatherableItem { Name = "Aneth", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", PropertyName = "SprigOfMistDill" });

            GatherableItems.Add(new GatherableItem { Name = "Marron sombre", Job = Job.Botanist, Localisation = "The Dravanian Forelands", PropertyName = "DarkChestnut" });
            GatherableItems.Add(new GatherableItem { Name = "Rondin de châtaignier sombre", Job = Job.Botanist, Localisation = "The Dravanian Forelands", PropertyName = "DarkChestnutLog" });
            GatherableItems.Add(new GatherableItem { Name = "Branche de châtaignier sombre", Job = Job.Botanist, Localisation = "The Dravanian Forelands", PropertyName = "DarkChestnutBranch" });
            GatherableItems.Add(new GatherableItem { Name = "Échalion cyclope", Job = Job.Botanist, Localisation = "The Dravanian Forelands", PropertyName = "CyclopsOnion" });
            GatherableItems.Add(new GatherableItem { Name = "Blé des hautes terres", Job = Job.Botanist, Localisation = "The Dravanian Forelands", PropertyName = "HighlandWheat" });
            GatherableItems.Add(new GatherableItem { Name = "Tige de ramie", Job = Job.Botanist, Localisation = "The Dravanian Forelands", PropertyName = "StalkOfRamie" });

            GatherableItems.Add(new GatherableItem { Name = "Haricots émeraude", Job = Job.Botanist, Localisation = "The Churning Mists", PropertyName = "EmeraldBeans" });
            GatherableItems.Add(new GatherableItem { Name = "Betteraves de magma", Job = Job.Botanist, Localisation = "The Churning Mists", PropertyName = "MagmaBeet" });
            GatherableItems.Add(new GatherableItem { Name = "Cristal de terre", Job = Job.Botanist, Localisation = "The Churning Mists", PropertyName = "EarthCrystal_LandlordColony_BTN" });

            GatherableItems.Add(new GatherableItem { Name = "Rondin de cèdre", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", PropertyName = "CedarLog" });
            GatherableItems.Add(new GatherableItem { Name = "Branche de cèdre", Job = Job.Botanist, Localisation = "Coerthas Western Highlands", PropertyName = "CedarBranch" });

            /* A REALM REBORN */
            GatherableItems.Add(new GatherableItem { Name = "Groseille sanguine", Job = Job.Botanist, Localisation = "South Shroud", PropertyName = "BloodCurrants" });
            GatherableItems.Add(new GatherableItem { Name = "Truffe blanche", Job = Job.Botanist, Localisation = "South Shroud", PropertyName = "WhiteTruffle" });
            GatherableItems.Add(new GatherableItem { Name = "Aloès", Job = Job.Botanist, Localisation = "Southern Thanalan", PropertyName = "Aloe" });
            GatherableItems.Add(new GatherableItem { Name = "Fibres de lin", Job = Job.Botanist, Localisation = "South Shroud", PropertyName = "Flax" });
            GatherableItems.Add(new GatherableItem { Name = "Persil hyurgoth", Job = Job.Botanist, Localisation = "Lower La Noscea", PropertyName = "HighlandParsley" });

            GatherableItems.Add(new GatherableItem { Name = "Éclat de feu", Job = Job.Botanist, Localisation = "", PropertyName = "FireShard_BTN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat de glace", Job = Job.Botanist, Localisation = "", PropertyName = "IceShard_BTN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat de vent", Job = Job.Botanist, Localisation = "", PropertyName = "WindShard_BTN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat de terre", Job = Job.Botanist, Localisation = "", PropertyName = "EarthShard_BTN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat de foudre", Job = Job.Botanist, Localisation = "", PropertyName = "LightningShard_BTN" });
            GatherableItems.Add(new GatherableItem { Name = "Éclat d'eau", Job = Job.Botanist, Localisation = "", PropertyName = "WaterShard_BTN" });

            GatherableItems = new ObservableCollection<GatherableItem>(GatherableItems.OrderBy(i => i.Name).ToList());
        }

        public void EventSetter_OnHandler(object sender, MouseButtonEventArgs e)
        {
            GatherableItem item = ItemSelectionList.SelectedItem as GatherableItem;

            if (SelectedGatherableItems.Any(gatherableItem => gatherableItem.Name.Equals(item.Name) && gatherableItem.Job == item.Job &&
                                                      gatherableItem.Localisation.Equals(item.Localisation)))
            {
                return;
            }
            item.Quantity = 1;
            SelectedGatherableItems.Add(item);
        }

        public void RemoveGatherableItem_OnClick(object sender, RoutedEventArgs e)
        {
            GatherableItem item = ((ListBoxItem)SelectedItemList.ContainerFromElement((Button)sender)).Content as GatherableItem;

            if (SelectedGatherableItems.Any(gatherableItem => gatherableItem.Name.Equals(item.Name) && gatherableItem.Job == item.Job &&
                                                      gatherableItem.Localisation.Equals(item.Localisation)))
            {
                SelectedGatherableItems.Remove(item);
                EntraxModel.Instance.GetType().GetProperty(item.PropertyName).SetValue(EntraxModel.Instance, 0);
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
