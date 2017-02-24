using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml;
using WpfApplication1.Annotations;

namespace WpfApplication1.Model
{
    public class EntraxModel: INotifyPropertyChanged
    {
        #region SINGLETON

        private static EntraxModel _instance;

        private EntraxModel()
        {
        }

        public static EntraxModel Instance
        {
            get { return _instance ?? (_instance = new EntraxModel()); }
        }

        #endregion SINGLETON

        #region GENERAL

        public bool IsCheck
        {
            get { return _isCheck; }
            set
            {
                if (value == _isCheck) return;
                _isCheck = value;
                OnPropertyChanged();
            }
        }

        private bool _waitAtWaitingLocation;
        public bool WaitAtWaitingLocation
        {
            get { return _waitAtWaitingLocation; }
            set
            {
                _waitAtWaitingLocation = value;
                OnPropertyChanged();
            }
        }

        public int Waiting_AetheryteId
        {
            get { return _waitingAetheryteId; }
            set
            {
                if (value == _waitingAetheryteId) return;
                _waitingAetheryteId = value;
                OnPropertyChanged();
            }
        }

        public bool Use_House_Codechunck
        {
            get { return _useHouseCodechunck; }
            set
            {
                if (value == _useHouseCodechunck) return;
                _useHouseCodechunck = value;
                OnPropertyChanged();
            }
        }

        public bool Use_Aetheryte_Idyllshire
        {
            get { return _useAetheryteIdyllshire; }
            set
            {
                if (value == _useAetheryteIdyllshire) return;
                _useAetheryteIdyllshire = value;
                OnPropertyChanged();
            }
        }

        public bool Tangela
        {
            get { return _tangela; }
            set
            {
                if (value == _tangela) return;
                _tangela = value;
                OnPropertyChanged();
            }
        }

        public bool Onix
        {
            get { return _onix; }
            set
            {
                if (value == _onix) return;
                _onix = value;
                OnPropertyChanged();
            }
        }

        public bool Ditto
        {
            get { return _ditto; }
            set
            {
                if (value == _ditto) return;
                _ditto = value;
                OnPropertyChanged();
            }
        }

        public bool Magikarp
        {
            get { return _magikarp; }
            set
            {
                if (value == _magikarp) return;
                _magikarp = value;
                OnPropertyChanged();
            }
        }

        public bool Psyduck
        {
            get { return _psyduck; }
            set
            {
                if (value == _psyduck) return;
                _psyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Slowpoke
        {
            get { return _slowpoke; }
            set
            {
                if (value == _slowpoke) return;
                _slowpoke = value;
                OnPropertyChanged();
            }
        }

        public bool Umbreon
        {
            get { return _umbreon; }
            set
            {
                if (value == _umbreon) return;
                _umbreon = value;
                OnPropertyChanged();
            }
        }

        public bool Snorlax
        {
            get { return _snorlax; }
            set
            {
                if (value == _snorlax) return;
                _snorlax = value;
                OnPropertyChanged();
            }
        }

        public bool Unown
        {
            get { return _unown; }
            set
            {
                if (value == _unown) return;
                _unown = value;
                OnPropertyChanged();
            }
        }

        #endregion GENERAL

        #region TANGELA

        public string Sand_Collect_Rate_1Star_Tangela
        {
            get { return _sandCollectRate1StarTangela; }
            set
            {
                if (value == _sandCollectRate1StarTangela) return;
                _sandCollectRate1StarTangela = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_RadiantAstralMoraine_Tangela
        {
            get { return _collectRadiantAstralMoraineTangela; }
            set
            {
                if (value == _collectRadiantAstralMoraineTangela) return;
                _collectRadiantAstralMoraineTangela = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_LoversLaurel_Tangela
        {
            get { return _collectLoversLaurelTangela; }
            set
            {
                if (value == _collectLoversLaurelTangela) return;
                _collectLoversLaurelTangela = value;
                OnPropertyChanged();
            }
        }

        public string Sand_Collect_Rate_Tangela
        {
            get { return _sandCollectRateTangela; }
            set
            {
                if (value == _sandCollectRateTangela) return;
                _sandCollectRateTangela = value;
                OnPropertyChanged();
            }
        }

        public bool Gather_HighlandOregano_Tangela
        {
            get { return _gatherHighlandOreganoTangela; }
            set
            {
                if (value == _gatherHighlandOreganoTangela) return;
                _gatherHighlandOreganoTangela = value;
                OnPropertyChanged();
            }
        }

        public bool Gather_Furymint_Tangela
        {
            get { return _gatherFurymintTangela; }
            set
            {
                if (value == _gatherFurymintTangela) return;
                _gatherFurymintTangela = value;
                OnPropertyChanged();
            }
        }

        public bool Gather_BlackSoil_Tangela
        {
            get { return _gatherBlackSoilTangela; }
            set
            {
                if (value == _gatherBlackSoilTangela) return;
                _gatherBlackSoilTangela = value;
                OnPropertyChanged();
            }
        }

        public string CordialType_Tangela
        {
            get { return _cordialTypeTangela; }
            set
            {
                if (value == _cordialTypeTangela) return;
                _cordialTypeTangela = value;
                OnPropertyChanged();
            }
        }

        public string CordialTime_Tangela
        {
            get { return /*_cordialTimeTangela*/"Auto"; }
            set
            {
                if (value == _cordialTimeTangela) return;
                _cordialTimeTangela = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_0_4_Tangela
        {
            get { return _btn04Tangela; }
            set
            {
                if (value == _btn04Tangela) return;
                _btn04Tangela = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_4_8_Tangela
        {
            get { return _btn48Tangela; }
            set
            {
                if (value == _btn48Tangela) return;
                _btn48Tangela = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_4_8_Tangela
        {
            get { return _min48Tangela; }
            set
            {
                if (value == _min48Tangela) return;
                _min48Tangela = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_8_12_Tangela
        {
            get { return _btn812Tangela; }
            set
            {
                if (value == _btn812Tangela) return;
                _btn812Tangela = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_8_12_Tangela
        {
            get { return _min812Tangela; }
            set
            {
                if (value == _min812Tangela) return;
                _min812Tangela = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_12_16_Tangela
        {
            get { return _min1216Tangela; }
            set
            {
                if (value == _min1216Tangela) return;
                _min1216Tangela = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_16_20_Tangela
        {
            get { return _btn1620Tangela; }
            set
            {
                if (value == _btn1620Tangela) return;
                _btn1620Tangela = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_16_20_Tangela
        {
            get { return _min1620Tangela; }
            set
            {
                if (value == _min1620Tangela) return;
                _min1620Tangela = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_20_24_Tangela
        {
            get { return _btn2024Tangela; }
            set
            {
                if (value == _btn2024Tangela) return;
                _btn2024Tangela = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_20_24_Tangela
        {
            get { return _min2024Tangela; }
            set
            {
                if (value == _min2024Tangela) return;
                _min2024Tangela = value;
                OnPropertyChanged();
            }
        }

        #endregion TANGELA

        #region ONIX

        public string Sand_Collect_Rate_1Star_Onix
        {
            get { return _sandCollectRate1StarOnix; }
            set
            {
                if (value == _sandCollectRate1StarOnix) return;
                _sandCollectRate1StarOnix = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_RadiantAstralMoraine_Onix
        {
            get { return _collectRadiantAstralMoraineOnix; }
            set
            {
                if (value == _collectRadiantAstralMoraineOnix) return;
                _collectRadiantAstralMoraineOnix = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_LoversLaurel_Onix
        {
            get { return _collectLoversLaurelOnix; }
            set
            {
                if (value == _collectLoversLaurelOnix) return;
                _collectLoversLaurelOnix = value;
                OnPropertyChanged();
            }
        }

        public string Sand_Collect_Rate_Onix
        {
            get { return _sandCollectRateOnix; }
            set
            {
                if (value == _sandCollectRateOnix) return;
                _sandCollectRateOnix = value;
                OnPropertyChanged();
            }
        }

        public bool Gather_HighlandOregano_Onix
        {
            get { return _gatherHighlandOreganoOnix; }
            set
            {
                if (value == _gatherHighlandOreganoOnix) return;
                _gatherHighlandOreganoOnix = value;
                OnPropertyChanged();
            }
        }

        public bool Gather_Furymint_Onix
        {
            get { return _gatherFurymintOnix; }
            set
            {
                if (value == _gatherFurymintOnix) return;
                _gatherFurymintOnix = value;
                OnPropertyChanged();
            }
        }

        public bool Gather_BlackSoil_Onix
        {
            get { return _gatherBlackSoilOnix; }
            set
            {
                if (value == _gatherBlackSoilOnix) return;
                _gatherBlackSoilOnix = value;
                OnPropertyChanged();
            }
        }

        public string CordialType_Onix
        {
            get { return _cordialTypeOnix; }
            set
            {
                if (value == _cordialTypeOnix) return;
                _cordialTypeOnix = value;
                OnPropertyChanged();
            }
        }

        public string CordialTime_Onix
        {
            get { return _cordialTimeOnix; }
            set
            {
                if (value == _cordialTimeOnix) return;
                _cordialTimeOnix = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_0_4_Onix
        {
            get { return _btn04Onix; }
            set
            {
                if (value == _btn04Onix) return;
                _btn04Onix = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_4_8_Onix
        {
            get { return _btn48Onix; }
            set
            {
                if (value == _btn48Onix) return;
                _btn48Onix = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_4_8_Onix
        {
            get { return _min48Onix; }
            set
            {
                if (value == _min48Onix) return;
                _min48Onix = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_8_12_Onix
        {
            get { return _btn812Onix; }
            set
            {
                if (value == _btn812Onix) return;
                _btn812Onix = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_8_12_Onix
        {
            get { return _min812Onix; }
            set
            {
                if (value == _min812Onix) return;
                _min812Onix = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_12_16_Onix
        {
            get { return _min1216Onix; }
            set
            {
                if (value == _min1216Onix) return;
                _min1216Onix = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_16_20_Onix
        {
            get { return _btn1620Onix; }
            set
            {
                if (value == _btn1620Onix) return;
                _btn1620Onix = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_16_20_Onix
        {
            get { return _min1620Onix; }
            set
            {
                if (value == _min1620Onix) return;
                _min1620Onix = value;
                OnPropertyChanged();
            }
        }

        public bool BTN_20_24_Onix
        {
            get { return _btn2024Onix; }
            set
            {
                if (value == _btn2024Onix) return;
                _btn2024Onix = value;
                OnPropertyChanged();
            }
        }

        public bool MIN_20_24_Onix
        {
            get { return _min2024Onix; }
            set
            {
                if (value == _min2024Onix) return;
                _min2024Onix = value;
                OnPropertyChanged();
            }
        }

        #endregion ONIX

        #region DITTO

        public string CordialType_Ditto
        {
            get { return /*_cordialTypeDitto*/"Auto"; }
            set
            {
                if (value == _cordialTypeDitto) return;
                _cordialTypeDitto = value;
                OnPropertyChanged();
            }
        }

        public string CordialTime_Ditto
        {
            get { return /*_cordialTimeDitto*/"Auto"; }
            set
            {
                if (value == _cordialTimeDitto) return;
                _cordialTimeDitto = value;
                OnPropertyChanged();
            }
        }

        public bool DragonObsidian_Ditto
        {
            get { return _dragonObsidianDitto; }
            set
            {
                if (value == _dragonObsidianDitto) return;
                _dragonObsidianDitto = value;
                OnPropertyChanged();
            }
        }

        public string DragonObsidian_Rate_Ditto
        {
            get { return _dragonObsidianRateDitto; }
            set
            {
                if (value == _dragonObsidianRateDitto) return;
                _dragonObsidianRateDitto = value;
                OnPropertyChanged();
            }
        }

        public bool FossilizedDragonBone_Ditto
        {
            get { return _fossilizedDragonBoneDitto; }
            set
            {
                if (value == _fossilizedDragonBoneDitto) return;
                _fossilizedDragonBoneDitto = value;
                OnPropertyChanged();
            }
        }

        public string FossilizedDragonBone_Rate_Ditto
        {
            get { return _fossilizedDragonBoneRateDitto; }
            set
            {
                if (value == _fossilizedDragonBoneRateDitto) return;
                _fossilizedDragonBoneRateDitto = value;
                OnPropertyChanged();
            }
        }

        public bool Tektite_Ditto
        {
            get { return _tektiteDitto; }
            set
            {
                if (value == _tektiteDitto) return;
                _tektiteDitto = value;
                OnPropertyChanged();
            }
        }

        public string Tektite_Rate_Ditto
        {
            get { return _tektiteRateDitto; }
            set
            {
                if (value == _tektiteRateDitto) return;
                _tektiteRateDitto = value;
                OnPropertyChanged();
            }
        }

        public bool EventideJade_Ditto
        {
            get { return _eventideJadeDitto; }
            set
            {
                if (value == _eventideJadeDitto) return;
                _eventideJadeDitto = value;
                OnPropertyChanged();
            }
        }

        public string EventideJade_Rate_Ditto
        {
            get { return _eventideJadeRateDitto; }
            set
            {
                if (value == _eventideJadeRateDitto) return;
                _eventideJadeRateDitto = value;
                OnPropertyChanged();
            }
        }

        public bool CedarLog_Ditto
        {
            get { return _cedarLogDitto; }
            set
            {
                if (value == _cedarLogDitto) return;
                _cedarLogDitto = value;
                OnPropertyChanged();
            }
        }

        public string CedarLog_Rate_Ditto
        {
            get { return _cedarLogRateDitto; }
            set
            {
                if (value == _cedarLogRateDitto) return;
                _cedarLogRateDitto = value;
                OnPropertyChanged();
            }
        }

        public bool WindWidow_Ditto
        {
            get { return _windWidowDitto; }
            set
            {
                if (value == _windWidowDitto) return;
                _windWidowDitto = value;
                OnPropertyChanged();
            }
        }

        public string WindWidow_Rate_Ditto
        {
            get { return _windWidowRateDitto; }
            set
            {
                if (value == _windWidowRateDitto) return;
                _windWidowRateDitto = value;
                OnPropertyChanged();
            }
        }

        public bool CloudMushroom_Ditto
        {
            get { return _cloudMushroomDitto; }
            set
            {
                if (value == _cloudMushroomDitto) return;
                _cloudMushroomDitto = value;
                OnPropertyChanged();
            }
        }

        public string CloudMushroom_Rate_Ditto
        {
            get { return _cloudMushroomRateDitto; }
            set
            {
                if (value == _cloudMushroomRateDitto) return;
                _cloudMushroomRateDitto = value;
                OnPropertyChanged();
            }
        }

        public bool Periwinkle_Ditto
        {
            get { return _periwinkleDitto; }
            set
            {
                if (value == _periwinkleDitto) return;
                _periwinkleDitto = value;
                OnPropertyChanged();
            }
        }

        public string Periwinkle_Rate_Ditto
        {
            get { return _periwinkleRateDitto; }
            set
            {
                if (value == _periwinkleRateDitto) return;
                _periwinkleRateDitto = value;
                OnPropertyChanged();
            }
        }

        #endregion DITTO

        #region PSYDUCK

        public string Patience_Psyduck
        {
            get { return _patiencePsyduck; }
            set
            {
                if (value == _patiencePsyduck) return;
                _patiencePsyduck = value;
                OnPropertyChanged();
            }
        }

        public string CordialType_Psyduck
        {
            get { return _cordialTypePsyduck; }
            set
            {
                if (value == _cordialTypePsyduck) return;
                _cordialTypePsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool KeepFishing_Psyduck
        {
            get { return _keepFishingPsyduck; }
            set
            {
                if (value == _keepFishingPsyduck) return;
                _keepFishingPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool HraesvelgrsTear_Psyduck
        {
            get { return _hraesvelgrsTearPsyduck; }
            set
            {
                if (value == _hraesvelgrsTearPsyduck) return;
                _hraesvelgrsTearPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Scaleripper_Psyduck
        {
            get { return _scaleripperPsyduck; }
            set
            {
                if (value == _scaleripperPsyduck) return;
                _scaleripperPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool TheDreamweaver_Psyduck
        {
            get { return _theDreamweaverPsyduck; }
            set
            {
                if (value == _theDreamweaverPsyduck) return;
                _theDreamweaverPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Meteortoise_Psyduck
        {
            get { return _meteortoisePsyduck; }
            set
            {
                if (value == _meteortoisePsyduck) return;
                _meteortoisePsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Vidofnir_Psyduck
        {
            get { return _vidofnirPsyduck; }
            set
            {
                if (value == _vidofnirPsyduck) return;
                _vidofnirPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool TheSoulOfTheMartyr_Psyduck
        {
            get { return _theSoulOfTheMartyrPsyduck; }
            set
            {
                if (value == _theSoulOfTheMartyrPsyduck) return;
                _theSoulOfTheMartyrPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Inkfish_Psyduck
        {
            get { return _inkfishPsyduck; }
            set
            {
                if (value == _inkfishPsyduck) return;
                _inkfishPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool TheSecondOne_Psyduck
        {
            get { return _theSecondOnePsyduck; }
            set
            {
                if (value == _theSecondOnePsyduck) return;
                _theSecondOnePsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool AphoticPirarucu_Psyduck
        {
            get { return _aphoticPirarucuPsyduck; }
            set
            {
                if (value == _aphoticPirarucuPsyduck) return;
                _aphoticPirarucuPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool AmberSalamander_Psyduck
        {
            get { return _amberSalamanderPsyduck; }
            set
            {
                if (value == _amberSalamanderPsyduck) return;
                _amberSalamanderPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool FleeceStingray_Psyduck
        {
            get { return _fleeceStingrayPsyduck; }
            set
            {
                if (value == _fleeceStingrayPsyduck) return;
                _fleeceStingrayPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool LavaSnail_Psyduck
        {
            get { return _lavaSnailPsyduck; }
            set
            {
                if (value == _lavaSnailPsyduck) return;
                _lavaSnailPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool OliphantsTrunk_Psyduck
        {
            get { return _oliphantsTrunkPsyduck; }
            set
            {
                if (value == _oliphantsTrunkPsyduck) return;
                _oliphantsTrunkPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool ArmoredCatfish_Psyduck
        {
            get { return _armoredCatfishPsyduck; }
            set
            {
                if (value == _armoredCatfishPsyduck) return;
                _armoredCatfishPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool NeptoDragon_Psyduck
        {
            get { return _neptoDragonPsyduck; }
            set
            {
                if (value == _neptoDragonPsyduck) return;
                _neptoDragonPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool KunotheKiller_Psyduck
        {
            get { return _kunotheKillerPsyduck; }
            set
            {
                if (value == _kunotheKillerPsyduck) return;
                _kunotheKillerPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Shonisaurus_Psyduck
        {
            get { return _shonisaurusPsyduck; }
            set
            {
                if (value == _shonisaurusPsyduck) return;
                _shonisaurusPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Helicoprion_Psyduck
        {
            get { return _helicoprionPsyduck; }
            set
            {
                if (value == _helicoprionPsyduck) return;
                _helicoprionPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Namitaro_Psyduck
        {
            get { return _namitaroPsyduck; }
            set
            {
                if (value == _namitaroPsyduck) return;
                _namitaroPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Endoceras_Psyduck
        {
            get { return _endocerasPsyduck; }
            set
            {
                if (value == _endocerasPsyduck) return;
                _endocerasPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool TitanicSawfish_Psyduck
        {
            get { return _titanicSawfishPsyduck; }
            set
            {
                if (value == _titanicSawfishPsyduck) return;
                _titanicSawfishPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool NavigatorsBrand_Psyduck
        {
            get { return _navigatorsBrandPsyduck; }
            set
            {
                if (value == _navigatorsBrandPsyduck) return;
                _navigatorsBrandPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool FrilledShark_Psyduck
        {
            get { return _frilledSharkPsyduck; }
            set
            {
                if (value == _frilledSharkPsyduck) return;
                _frilledSharkPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool NinjaBetta_Psyduck
        {
            get { return _ninjaBettaPsyduck; }
            set
            {
                if (value == _ninjaBettaPsyduck) return;
                _ninjaBettaPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool MagicCarpet_Psyduck
        {
            get { return _magicCarpetPsyduck; }
            set
            {
                if (value == _magicCarpetPsyduck) return;
                _magicCarpetPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool TheGreatestBreamInTheWorld_Psyduck
        {
            get { return _theGreatestBreamInTheWorldPsyduck; }
            set
            {
                if (value == _theGreatestBreamInTheWorldPsyduck) return;
                _theGreatestBreamInTheWorldPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool ThunderboltEel_Psyduck
        {
            get { return _thunderboltEelPsyduck; }
            set
            {
                if (value == _thunderboltEelPsyduck) return;
                _thunderboltEelPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool DravanianBass_Psyduck
        {
            get { return _dravanianBassPsyduck; }
            set
            {
                if (value == _dravanianBassPsyduck) return;
                _dravanianBassPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Pteranodon_Psyduck
        {
            get { return _pteranodonPsyduck; }
            set
            {
                if (value == _pteranodonPsyduck) return;
                _pteranodonPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool ThaliakCaiman_Psyduck
        {
            get { return _thaliakCaimanPsyduck; }
            set
            {
                if (value == _thaliakCaimanPsyduck) return;
                _thaliakCaimanPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Tupuxuara_Psyduck
        {
            get { return _tupuxuaraPsyduck; }
            set
            {
                if (value == _tupuxuaraPsyduck) return;
                _tupuxuaraPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool Caiman_Psyduck
        {
            get { return _caimanPsyduck; }
            set
            {
                if (value == _caimanPsyduck) return;
                _caimanPsyduck = value;
                OnPropertyChanged();
            }
        }

        public bool PipiraPira_Psyduck
        {
            get { return _pipiraPiraPsyduck; }
            set
            {
                if (value == _pipiraPiraPsyduck) return;
                _pipiraPiraPsyduck = value;
                OnPropertyChanged();
            }
        }

        #endregion PSYDUCK

        #region SNORLAX

        public bool DisableRotationOverride_Snorlax
        {
            get { return _disableRotationOverrideSnorlax; }
            set
            {
                if (value == _disableRotationOverrideSnorlax) return;
                _disableRotationOverrideSnorlax = value;
                OnPropertyChanged();
            }
        }

        public string GatherIncrease_Snorlax
        {
            get { return _gatherIncreaseSnorlax; }
            set
            {
                if (value == _gatherIncreaseSnorlax) return;
                _gatherIncreaseSnorlax = value;
                OnPropertyChanged();
            }
        }

        public bool SpiritBond_Snorlax
        {
            get { return _spiritBondSnorlax; }
            set
            {
                if (value == _spiritBondSnorlax) return;
                _spiritBondSnorlax = value;
                OnPropertyChanged();
            }
        }

        public int RawCitrine
        {
            get { return _rawCitrine; }
            set
            {
                if (value == _rawCitrine) return;
                _rawCitrine = value;
                OnPropertyChanged();
            }
        }

        public int IceCrystal_RedRime
        {
            get { return _iceCrystalRedRime; }
            set
            {
                if (value == _iceCrystalRedRime) return;
                _iceCrystalRedRime = value;
                OnPropertyChanged();
            }
        }

        public int AbalathianSpringWater
        {
            get { return _abalathianSpringWater; }
            set
            {
                if (value == _abalathianSpringWater) return;
                _abalathianSpringWater = value;
                OnPropertyChanged();
            }
        }

        public int AurumRegisSand
        {
            get { return _aurumRegisSand; }
            set
            {
                if (value == _aurumRegisSand) return;
                _aurumRegisSand = value;
                OnPropertyChanged();
            }
        }

        public int LightningCrystal_VoorSianSiran_MIN
        {
            get { return _lightningCrystalVoorSianSiranMin; }
            set
            {
                if (value == _lightningCrystalVoorSianSiranMin) return;
                _lightningCrystalVoorSianSiranMin = value;
                OnPropertyChanged();
            }
        }

        public int WaterCrystal_VoorSianSiran_MIN
        {
            get { return _waterCrystalVoorSianSiranMin; }
            set
            {
                if (value == _waterCrystalVoorSianSiranMin) return;
                _waterCrystalVoorSianSiranMin = value;
                OnPropertyChanged();
            }
        }

        public int BeastkinHorn
        {
            get { return _beastkinHorn; }
            set
            {
                if (value == _beastkinHorn) return;
                _beastkinHorn = value;
                OnPropertyChanged();
            }
        }

        public int RawCarnelian
        {
            get { return _rawCarnelian; }
            set
            {
                if (value == _rawCarnelian) return;
                _rawCarnelian = value;
                OnPropertyChanged();
            }
        }

        public int RawOpal
        {
            get { return _rawOpal; }
            set
            {
                if (value == _rawOpal) return;
                _rawOpal = value;
                OnPropertyChanged();
            }
        }

        public int FireCrystal_AvaloniaFallen_MIN
        {
            get { return _fireCrystalAvaloniaFallenMin; }
            set
            {
                if (value == _fireCrystalAvaloniaFallenMin) return;
                _fireCrystalAvaloniaFallenMin = value;
                OnPropertyChanged();
            }
        }

        public int LumythriteSand
        {
            get { return _lumythriteSand; }
            set
            {
                if (value == _lumythriteSand) return;
                _lumythriteSand = value;
                OnPropertyChanged();
            }
        }

        public int CloudMica
        {
            get { return _cloudMica; }
            set
            {
                if (value == _cloudMica) return;
                _cloudMica = value;
                OnPropertyChanged();
            }
        }

        public int HardsilverSand
        {
            get { return _hardsilverSand; }
            set
            {
                if (value == _hardsilverSand) return;
                _hardsilverSand = value;
                OnPropertyChanged();
            }
        }

        public int EarthCrystal_LandlordColony_MIN
        {
            get { return _earthCrystalLandlordColonyMin; }
            set
            {
                if (value == _earthCrystalLandlordColonyMin) return;
                _earthCrystalLandlordColonyMin = value;
                OnPropertyChanged();
            }
        }

        public int HardsilverOre
        {
            get { return _hardsilverOre; }
            set
            {
                if (value == _hardsilverOre) return;
                _hardsilverOre = value;
                OnPropertyChanged();
            }
        }

        public int RawChrysolite
        {
            get { return _rawChrysolite; }
            set
            {
                if (value == _rawChrysolite) return;
                _rawChrysolite = value;
                OnPropertyChanged();
            }
        }

        public int WyrmObsidian
        {
            get { return _wyrmObsidian; }
            set
            {
                if (value == _wyrmObsidian) return;
                _wyrmObsidian = value;
                OnPropertyChanged();
            }
        }

        public int WindCrystal_TheMakersQuarter
        {
            get { return _windCrystalTheMakersQuarter; }
            set
            {
                if (value == _windCrystalTheMakersQuarter) return;
                _windCrystalTheMakersQuarter = value;
                OnPropertyChanged();
            }
        }

        public int MythriteSand
        {
            get { return _mythriteSand; }
            set
            {
                if (value == _mythriteSand) return;
                _mythriteSand = value;
                OnPropertyChanged();
            }
        }

        public int IceCrystal_Twinpools_MIN51
        {
            get { return _iceCrystalTwinpoolsMin51; }
            set
            {
                if (value == _iceCrystalTwinpoolsMin51) return;
                _iceCrystalTwinpoolsMin51 = value;
                OnPropertyChanged();
            }
        }

        public int MythriteOre
        {
            get { return _mythriteOre; }
            set
            {
                if (value == _mythriteOre) return;
                _mythriteOre = value;
                OnPropertyChanged();
            }
        }

        public int RawLarimar
        {
            get { return _rawLarimar; }
            set
            {
                if (value == _rawLarimar) return;
                _rawLarimar = value;
                OnPropertyChanged();
            }
        }

        public int RawMormorion
        {
            get { return _rawMormorion; }
            set
            {
                if (value == _rawMormorion) return;
                _rawMormorion = value;
                OnPropertyChanged();
            }
        }

        public int IceCrystal_GorganeHolding
        {
            get { return _iceCrystalGorganeHolding; }
            set
            {
                if (value == _iceCrystalGorganeHolding) return;
                _iceCrystalGorganeHolding = value;
                OnPropertyChanged();
            }
        }

        public int RawAgate
        {
            get { return _rawAgate; }
            set
            {
                if (value == _rawAgate) return;
                _rawAgate = value;
                OnPropertyChanged();
            }
        }

        public int RawTigersEye
        {
            get { return _rawTigersEye; }
            set
            {
                if (value == _rawTigersEye) return;
                _rawTigersEye = value;
                OnPropertyChanged();
            }
        }

        public int DravanianSpringWater
        {
            get { return _dravanianSpringWater; }
            set
            {
                if (value == _dravanianSpringWater) return;
                _dravanianSpringWater = value;
                OnPropertyChanged();
            }
        }

        public int FireCrystal_TheSmolderingWastes_MIN
        {
            get { return _fireCrystalTheSmolderingWastesMin; }
            set
            {
                if (value == _fireCrystalTheSmolderingWastesMin) return;
                _fireCrystalTheSmolderingWastesMin = value;
                OnPropertyChanged();
            }
        }

        public int TitaniumOre
        {
            get { return _titaniumOre; }
            set
            {
                if (value == _titaniumOre) return;
                _titaniumOre = value;
                OnPropertyChanged();
            }
        }

        public int RawStarRuby
        {
            get { return _rawStarRuby; }
            set
            {
                if (value == _rawStarRuby) return;
                _rawStarRuby = value;
                OnPropertyChanged();
            }
        }

        public int RawStarSapphire
        {
            get { return _rawStarSapphire; }
            set
            {
                if (value == _rawStarSapphire) return;
                _rawStarSapphire = value;
                OnPropertyChanged();
            }
        }

        public int FireCrystal_ChocoboForest_MIN
        {
            get { return _fireCrystalChocoboForestMin; }
            set
            {
                if (value == _fireCrystalChocoboForestMin) return;
                _fireCrystalChocoboForestMin = value;
                OnPropertyChanged();
            }
        }

        public int DragonObsidian
        {
            get { return _dragonObsidian; }
            set
            {
                if (value == _dragonObsidian) return;
                _dragonObsidian = value;
                OnPropertyChanged();
            }
        }

        public int IceCrystal_Riversmeet_MIN
        {
            get { return _iceCrystalRiversmeetMin; }
            set
            {
                if (value == _iceCrystalRiversmeetMin) return;
                _iceCrystalRiversmeetMin = value;
                OnPropertyChanged();
            }
        }

        public int WhitefrostCottonBoll
        {
            get { return _whitefrostCottonBoll; }
            set
            {
                if (value == _whitefrostCottonBoll) return;
                _whitefrostCottonBoll = value;
                OnPropertyChanged();
            }
        }

        public int Coriander
        {
            get { return _coriander; }
            set
            {
                if (value == _coriander) return;
                _coriander = value;
                OnPropertyChanged();
            }
        }

        public int Rue
        {
            get { return _rue; }
            set
            {
                if (value == _rue) return;
                _rue = value;
                OnPropertyChanged();
            }
        }

        public int IceCrystal_Twinpools_BTN56
        {
            get { return _iceCrystalTwinpoolsBtn56; }
            set
            {
                if (value == _iceCrystalTwinpoolsBtn56) return;
                _iceCrystalTwinpoolsBtn56 = value;
                OnPropertyChanged();
            }
        }

        public int BirchLog
        {
            get { return _birchLog; }
            set
            {
                if (value == _birchLog) return;
                _birchLog = value;
                OnPropertyChanged();
            }
        }

        public int BirchBranch
        {
            get { return _birchBranch; }
            set
            {
                if (value == _birchBranch) return;
                _birchBranch = value;
                OnPropertyChanged();
            }
        }

        public int BirchSap
        {
            get { return _birchSap; }
            set
            {
                if (value == _birchSap) return;
                _birchSap = value;
                OnPropertyChanged();
            }
        }

        public int WaterCrystal_VoorSianSiran_BTN
        {
            get { return _waterCrystalVoorSianSiranBtn; }
            set
            {
                if (value == _waterCrystalVoorSianSiranBtn) return;
                _waterCrystalVoorSianSiranBtn = value;
                OnPropertyChanged();
            }
        }

        public int Coneflower
        {
            get { return _coneflower; }
            set
            {
                if (value == _coneflower) return;
                _coneflower = value;
                OnPropertyChanged();
            }
        }

        public int FireCrystal_AvaloniaFallen_BTN
        {
            get { return _fireCrystalAvaloniaFallenBtn; }
            set
            {
                if (value == _fireCrystalAvaloniaFallenBtn) return;
                _fireCrystalAvaloniaFallenBtn = value;
                OnPropertyChanged();
            }
        }

        public int CamphorwoodBranch
        {
            get { return _camphorwoodBranch; }
            set
            {
                if (value == _camphorwoodBranch) return;
                _camphorwoodBranch = value;
                OnPropertyChanged();
            }
        }

        public int CamphorwoodLog
        {
            get { return _camphorwoodLog; }
            set
            {
                if (value == _camphorwoodLog) return;
                _camphorwoodLog = value;
                OnPropertyChanged();
            }
        }

        public int Dandelion
        {
            get { return _dandelion; }
            set
            {
                if (value == _dandelion) return;
                _dandelion = value;
                OnPropertyChanged();
            }
        }

        public int EarthCrystal_FourArms
        {
            get { return _earthCrystalFourArms; }
            set
            {
                if (value == _earthCrystalFourArms) return;
                _earthCrystalFourArms = value;
                OnPropertyChanged();
            }
        }

        public int CowBitter
        {
            get { return _cowBitter; }
            set
            {
                if (value == _cowBitter) return;
                _cowBitter = value;
                OnPropertyChanged();
            }
        }

        public int Gaelicatnip
        {
            get { return _gaelicatnip; }
            set
            {
                if (value == _gaelicatnip) return;
                _gaelicatnip = value;
                OnPropertyChanged();
            }
        }

        public int WindCrystal_TheAnsweringQuarter
        {
            get { return _windCrystalTheAnsweringQuarter; }
            set
            {
                if (value == _windCrystalTheAnsweringQuarter) return;
                _windCrystalTheAnsweringQuarter = value;
                OnPropertyChanged();
            }
        }

        public int RainbowCottonBoll
        {
            get { return _rainbowCottonBoll; }
            set
            {
                if (value == _rainbowCottonBoll) return;
                _rainbowCottonBoll = value;
                OnPropertyChanged();
            }
        }

        public int SprigOfMistDill
        {
            get { return _sprigOfMistDill; }
            set
            {
                if (value == _sprigOfMistDill) return;
                _sprigOfMistDill = value;
                OnPropertyChanged();
            }
        }

        public int IceCrystal_Twinpools_BTN51
        {
            get { return _iceCrystalTwinpoolsBtn51; }
            set
            {
                if (value == _iceCrystalTwinpoolsBtn51) return;
                _iceCrystalTwinpoolsBtn51 = value;
                OnPropertyChanged();
            }
        }

        public int DarkChestnut
        {
            get { return _darkChestnut; }
            set
            {
                if (value == _darkChestnut) return;
                _darkChestnut = value;
                OnPropertyChanged();
            }
        }

        public int DarkChestnutLog
        {
            get { return _darkChestnutLog; }
            set
            {
                if (value == _darkChestnutLog) return;
                _darkChestnutLog = value;
                OnPropertyChanged();
            }
        }

        public int DarkChestnutBranch
        {
            get { return _darkChestnutBranch; }
            set
            {
                if (value == _darkChestnutBranch) return;
                _darkChestnutBranch = value;
                OnPropertyChanged();
            }
        }

        public int FireCrystal_TheSmolderingWastes_BTN
        {
            get { return _fireCrystalTheSmolderingWastesBtn; }
            set
            {
                if (value == _fireCrystalTheSmolderingWastesBtn) return;
                _fireCrystalTheSmolderingWastesBtn = value;
                OnPropertyChanged();
            }
        }

        public int CyclopsOnion
        {
            get { return _cyclopsOnion; }
            set
            {
                if (value == _cyclopsOnion) return;
                _cyclopsOnion = value;
                OnPropertyChanged();
            }
        }

        public int HighlandWheat
        {
            get { return _highlandWheat; }
            set
            {
                if (value == _highlandWheat) return;
                _highlandWheat = value;
                OnPropertyChanged();
            }
        }

        public int StalkOfRamie
        {
            get { return _stalkOfRamie; }
            set
            {
                if (value == _stalkOfRamie) return;
                _stalkOfRamie = value;
                OnPropertyChanged();
            }
        }

        public int FireCrystal_ChocoboForest_BTN
        {
            get { return _fireCrystalChocoboForestBtn; }
            set
            {
                if (value == _fireCrystalChocoboForestBtn) return;
                _fireCrystalChocoboForestBtn = value;
                OnPropertyChanged();
            }
        }

        public int EmeraldBeans
        {
            get { return _emeraldBeans; }
            set
            {
                if (value == _emeraldBeans) return;
                _emeraldBeans = value;
                OnPropertyChanged();
            }
        }

        public int MagmaBeet
        {
            get { return _magmaBeet; }
            set
            {
                if (value == _magmaBeet) return;
                _magmaBeet = value;
                OnPropertyChanged();
            }
        }

        public int EarthCrystal_LandlordColony_BTN
        {
            get { return _earthCrystalLandlordColonyBtn; }
            set
            {
                if (value == _earthCrystalLandlordColonyBtn) return;
                _earthCrystalLandlordColonyBtn = value;
                OnPropertyChanged();
            }
        }

        public int CedarLog
        {
            get { return _cedarLog; }
            set
            {
                if (value == _cedarLog) return;
                _cedarLog = value;
                OnPropertyChanged();
            }
        }

        public int CedarBranch
        {
            get { return _cedarBranch; }
            set
            {
                if (value == _cedarBranch) return;
                _cedarBranch = value;
                OnPropertyChanged();
            }
        }

        public int IceCrystal_Riversmeet_BTN
        {
            get { return _iceCrystalRiversmeetBtn; }
            set
            {
                if (value == _iceCrystalRiversmeetBtn) return;
                _iceCrystalRiversmeetBtn = value;
                OnPropertyChanged();
            }
        }

        public int BloodCurrants
        {
            get { return _bloodCurrants; }
            set
            {
                if (value == _bloodCurrants) return;
                _bloodCurrants = value;
                OnPropertyChanged();
            }
        }

        public int WhiteTruffle
        {
            get { return _whiteTruffle; }
            set
            {
                if (value == _whiteTruffle) return;
                _whiteTruffle = value;
                OnPropertyChanged();
            }
        }

        public int Aloe
        {
            get { return _aloe; }
            set
            {
                if (value == _aloe) return;
                _aloe = value;
                OnPropertyChanged();
            }
        }

        public int Flax
        {
            get { return _flax; }
            set
            {
                if (value == _flax) return;
                _flax = value;
                OnPropertyChanged();
            }
        }

        public int HighlandParsley
        {
            get { return _highlandParsley; }
            set
            {
                if (value == _highlandParsley) return;
                _highlandParsley = value;
                OnPropertyChanged();
            }
        }

        public int FireShard_BTN
        {
            get { return _fireShardBtn; }
            set
            {
                if (value == _fireShardBtn) return;
                _fireShardBtn = value;
                OnPropertyChanged();
            }
        }

        public int FireCrystal_BTN
        {
            get { return _fireCrystalBtn; }
            set
            {
                if (value == _fireCrystalBtn) return;
                _fireCrystalBtn = value;
                OnPropertyChanged();
            }
        }

        public int IceShard_BTN
        {
            get { return _iceShardBtn; }
            set
            {
                if (value == _iceShardBtn) return;
                _iceShardBtn = value;
                OnPropertyChanged();
            }
        }

        public int IceCrystal_BTN
        {
            get { return _iceCrystalBtn; }
            set
            {
                if (value == _iceCrystalBtn) return;
                _iceCrystalBtn = value;
                OnPropertyChanged();
            }
        }

        public int WindShard_BTN
        {
            get { return _windShardBtn; }
            set
            {
                if (value == _windShardBtn) return;
                _windShardBtn = value;
                OnPropertyChanged();
            }
        }

        public int WindCrystal_BTN
        {
            get { return _windCrystalBtn; }
            set
            {
                if (value == _windCrystalBtn) return;
                _windCrystalBtn = value;
                OnPropertyChanged();
            }
        }

        public int EarthShard_BTN
        {
            get { return _earthShardBtn; }
            set
            {
                if (value == _earthShardBtn) return;
                _earthShardBtn = value;
                OnPropertyChanged();
            }
        }

        public int EarthCrystal_BTN
        {
            get { return _earthCrystalBtn; }
            set
            {
                if (value == _earthCrystalBtn) return;
                _earthCrystalBtn = value;
                OnPropertyChanged();
            }
        }

        public int LightningShard_BTN
        {
            get { return _lightningShardBtn; }
            set
            {
                if (value == _lightningShardBtn) return;
                _lightningShardBtn = value;
                OnPropertyChanged();
            }
        }

        public int LightningCrystal_BTN
        {
            get { return _lightningCrystalBtn; }
            set
            {
                if (value == _lightningCrystalBtn) return;
                _lightningCrystalBtn = value;
                OnPropertyChanged();
            }
        }

        public int WaterShard_BTN
        {
            get { return _waterShardBtn; }
            set
            {
                if (value == _waterShardBtn) return;
                _waterShardBtn = value;
                OnPropertyChanged();
            }
        }

        public int WaterCrystal_BTN
        {
            get { return _waterCrystalBtn; }
            set
            {
                if (value == _waterCrystalBtn) return;
                _waterCrystalBtn = value;
                OnPropertyChanged();
            }
        }

        public int CobaltOre
        {
            get { return _cobaltOre; }
            set
            {
                if (value == _cobaltOre) return;
                _cobaltOre = value;
                OnPropertyChanged();
            }
        }

        public int BasiliskEgg
        {
            get { return _basiliskEgg; }
            set
            {
                if (value == _basiliskEgg) return;
                _basiliskEgg = value;
                OnPropertyChanged();
            }
        }

        public int ElectrumOre
        {
            get { return _electrumOre; }
            set
            {
                if (value == _electrumOre) return;
                _electrumOre = value;
                OnPropertyChanged();
            }
        }

        public int MythrilOre
        {
            get { return _mythrilOre; }
            set
            {
                if (value == _mythrilOre) return;
                _mythrilOre = value;
                OnPropertyChanged();
            }
        }

        public int SilverOre
        {
            get { return _silverOre; }
            set
            {
                if (value == _silverOre) return;
                _silverOre = value;
                OnPropertyChanged();
            }
        }

        public int EffervescentWater
        {
            get { return _effervescentWater; }
            set
            {
                if (value == _effervescentWater) return;
                _effervescentWater = value;
                OnPropertyChanged();
            }
        }

        public int FireShard_MIN
        {
            get { return _fireShardMin; }
            set
            {
                if (value == _fireShardMin) return;
                _fireShardMin = value;
                OnPropertyChanged();
            }
        }

        public int FireCrystal_MIN
        {
            get { return _fireCrystalMin; }
            set
            {
                if (value == _fireCrystalMin) return;
                _fireCrystalMin = value;
                OnPropertyChanged();
            }
        }

        public int IceShard_MIN
        {
            get { return _iceShardMin; }
            set
            {
                if (value == _iceShardMin) return;
                _iceShardMin = value;
                OnPropertyChanged();
            }
        }

        public int IceCrystal_MIN
        {
            get { return _iceCrystalMin; }
            set
            {
                if (value == _iceCrystalMin) return;
                _iceCrystalMin = value;
                OnPropertyChanged();
            }
        }

        public int WindShard_MIN
        {
            get { return _windShardMin; }
            set
            {
                if (value == _windShardMin) return;
                _windShardMin = value;
                OnPropertyChanged();
            }
        }

        public int WindCrystal_MIN
        {
            get { return _windCrystalMin; }
            set
            {
                if (value == _windCrystalMin) return;
                _windCrystalMin = value;
                OnPropertyChanged();
            }
        }

        public int EarthShard_MIN
        {
            get { return _earthShardMin; }
            set
            {
                if (value == _earthShardMin) return;
                _earthShardMin = value;
                OnPropertyChanged();
            }
        }

        public int EarthCrystal_MIN
        {
            get { return _earthCrystalMin; }
            set
            {
                if (value == _earthCrystalMin) return;
                _earthCrystalMin = value;
                OnPropertyChanged();
            }
        }

        public int LightningShard_MIN
        {
            get { return _lightningShardMin; }
            set
            {
                if (value == _lightningShardMin) return;
                _lightningShardMin = value;
                OnPropertyChanged();
            }
        }

        public int LightningCrystal_MIN
        {
            get { return _lightningCrystalMin; }
            set
            {
                if (value == _lightningCrystalMin) return;
                _lightningCrystalMin = value;
                OnPropertyChanged();
            }
        }

        public int WaterShard_MIN
        {
            get { return _waterShardMin; }
            set
            {
                if (value == _waterShardMin) return;
                _waterShardMin = value;
                OnPropertyChanged();
            }
        }

        public int WaterCrystal_MIN
        {
            get { return _waterCrystalMin; }
            set
            {
                if (value == _waterCrystalMin) return;
                _waterCrystalMin = value;
                OnPropertyChanged();
            }
        }

        #endregion SNORLAX

        #region UNOWN

        public string GatherIncrease_50_60
        {
            get { return _gatherIncrease5060; }
            set
            {
                if (value == _gatherIncrease5060) return;
                _gatherIncrease5060 = value;
                OnPropertyChanged();
            }
        }

        public string GatherIncrease_1Star
        {
            get { return _gatherIncrease1Star; }
            set
            {
                if (value == _gatherIncrease1Star) return;
                _gatherIncrease1Star = value;
                OnPropertyChanged();
            }
        }

        public string GatherIncrease_1StarPlus
        {
            get { return _gatherIncrease1StarPlus; }
            set
            {
                if (value == _gatherIncrease1StarPlus) return;
                _gatherIncrease1StarPlus = value;
                OnPropertyChanged();
            }
        }

        public string GatherIncrease_3Star
        {
            get { return _gatherIncrease3Star; }
            set
            {
                if (value == _gatherIncrease3Star) return;
                _gatherIncrease3Star = value;
                OnPropertyChanged();
            }
        }

        public bool DisableRotationOverride_50_60
        {
            get { return _disableRotationOverride5060; }
            set
            {
                if (value == _disableRotationOverride5060) return;
                _disableRotationOverride5060 = value;
                OnPropertyChanged();
            }
        }

        public bool DisableRotationOverride_1Star
        {
            get { return _disableRotationOverride1Star; }
            set
            {
                if (value == _disableRotationOverride1Star) return;
                _disableRotationOverride1Star = value;
                OnPropertyChanged();
            }
        }

        public bool DisableRotationOverride_1StarPlus
        {
            get { return _disableRotationOverride1StarPlus; }
            set
            {
                if (value == _disableRotationOverride1StarPlus) return;
                _disableRotationOverride1StarPlus = value;
                OnPropertyChanged();
            }
        }

        public bool DisableRotationOverride_3Star
        {
            get { return _disableRotationOverride3Star; }
            set
            {
                if (value == _disableRotationOverride3Star) return;
                _disableRotationOverride3Star = value;
                OnPropertyChanged();
            }
        }
        
        public bool Cluster_1AM
        {
            get { return _cluster_1Am; }
            set
            {
                if (value == _cluster_1Am) return;
                _cluster_1Am = value;
                OnPropertyChanged();
            }
        }

        public bool Meteorite
        {
            get { return _meteorite; }
            set
            {
                if (value == _meteorite) return;
                _meteorite = value;
                OnPropertyChanged();
            }
        }

        public bool SmithsoniteOre
        {
            get { return _smithsoniteOre; }
            set
            {
                if (value == _smithsoniteOre) return;
                _smithsoniteOre = value;
                OnPropertyChanged();
            }
        }

        public bool SilkwormCocoon
        {
            get { return _silkwormCocoon; }
            set
            {
                if (value == _silkwormCocoon) return;
                _silkwormCocoon = value;
                OnPropertyChanged();
            }
        }

        public bool DarksteelOre
        {
            get { return _darksteelOre; }
            set
            {
                if (value == _darksteelOre) return;
                _darksteelOre = value;
                OnPropertyChanged();
            }
        }

        public bool Cluster_1PM
        {
            get { return _cluster_1Pm; }
            set
            {
                if (value == _cluster_1Pm) return;
                _cluster_1Pm = value;
                OnPropertyChanged();
            }
        }

        public bool FrostCottonBoll
        {
            get { return _frostCottonBoll; }
            set
            {
                if (value == _frostCottonBoll) return;
                _frostCottonBoll = value;
                OnPropertyChanged();
            }
        }

        public bool VampirePlant
        {
            get { return _vampirePlant; }
            set
            {
                if (value == _vampirePlant) return;
                _vampirePlant = value;
                OnPropertyChanged();
            }
        }

        public bool FragrantLog
        {
            get { return _fragrantLog; }
            set
            {
                if (value == _fragrantLog) return;
                _fragrantLog = value;
                OnPropertyChanged();
            }
        }

        public bool AntumbralRock
        {
            get { return _antumbralRock; }
            set
            {
                if (value == _antumbralRock) return;
                _antumbralRock = value;
                OnPropertyChanged();
            }
        }

        public bool BlackTruffle
        {
            get { return _blackTruffle; }
            set
            {
                if (value == _blackTruffle) return;
                _blackTruffle = value;
                OnPropertyChanged();
            }
        }

        public bool DzemaelTomato
        {
            get { return _dzemaelTomato; }
            set
            {
                if (value == _dzemaelTomato) return;
                _dzemaelTomato = value;
                OnPropertyChanged();
            }
        }

        public bool DzemaelTomatoSeeds
        {
            get { return _dzemaelTomatoSeeds; }
            set
            {
                if (value == _dzemaelTomatoSeeds) return;
                _dzemaelTomatoSeeds = value;
                OnPropertyChanged();
            }
        }

        public bool OldWorldFigSeeds
        {
            get { return _oldWorldFigSeeds; }
            set
            {
                if (value == _oldWorldFigSeeds) return;
                _oldWorldFigSeeds = value;
                OnPropertyChanged();
            }
        }

        public bool OldWorldFig
        {
            get { return _oldWorldFig; }
            set
            {
                if (value == _oldWorldFig) return;
                _oldWorldFig = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_OldWorldFig
        {
            get { return _collectOldWorldFig; }
            set
            {
                if (value == _collectOldWorldFig) return;
                _collectOldWorldFig = value;
                OnPropertyChanged();
            }
        }

        public bool YellowQuartz
        {
            get { return _yellowQuartz; }
            set
            {
                if (value == _yellowQuartz) return;
                _yellowQuartz = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_YellowQuartz
        {
            get { return _collectYellowQuartz; }
            set
            {
                if (value == _collectYellowQuartz) return;
                _collectYellowQuartz = value;
                OnPropertyChanged();
            }
        }

        public bool GreenQuartz
        {
            get { return _greenQuartz; }
            set
            {
                if (value == _greenQuartz) return;
                _greenQuartz = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_GreenQuartz
        {
            get { return _collectGreenQuartz; }
            set
            {
                if (value == _collectGreenQuartz) return;
                _collectGreenQuartz = value;
                OnPropertyChanged();
            }
        }

        public bool LightKidneyOre
        {
            get { return _lightKidneyOre; }
            set
            {
                if (value == _lightKidneyOre) return;
                _lightKidneyOre = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_LightKidneyOre
        {
            get { return _collectLightKidneyOre; }
            set
            {
                if (value == _collectLightKidneyOre) return;
                _collectLightKidneyOre = value;
                OnPropertyChanged();
            }
        }

        public bool Cuprite
        {
            get { return _cuprite; }
            set
            {
                if (value == _cuprite) return;
                _cuprite = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_Cuprite
        {
            get { return _collectCuprite; }
            set
            {
                if (value == _collectCuprite) return;
                _collectCuprite = value;
                OnPropertyChanged();
            }
        }

        public bool LumythriteOre
        {
            get { return _lumythriteOre; }
            set
            {
                if (value == _lumythriteOre) return;
                _lumythriteOre = value;
                OnPropertyChanged();
            }
        }

        public bool Ferberite
        {
            get { return _ferberite; }
            set
            {
                if (value == _ferberite) return;
                _ferberite = value;
                OnPropertyChanged();
            }
        }

        public bool RawTopaz
        {
            get { return _rawTopaz; }
            set
            {
                if (value == _rawTopaz) return;
                _rawTopaz = value;
                OnPropertyChanged();
            }
        }

        public bool RawIolite
        {
            get { return _rawIolite; }
            set
            {
                if (value == _rawIolite) return;
                _rawIolite = value;
                OnPropertyChanged();
            }
        }

        public bool OldGrowthCamphorwoodLog
        {
            get { return _oldGrowthCamphorwoodLog; }
            set
            {
                if (value == _oldGrowthCamphorwoodLog) return;
                _oldGrowthCamphorwoodLog = value;
                OnPropertyChanged();
            }
        }

        public bool CrystallizedSap
        {
            get { return _crystallizedSap; }
            set
            {
                if (value == _crystallizedSap) return;
                _crystallizedSap = value;
                OnPropertyChanged();
            }
        }

        public bool PlatinumOre
        {
            get { return _platinumOre; }
            set
            {
                if (value == _platinumOre) return;
                _platinumOre = value;
                OnPropertyChanged();
            }
        }

        public bool NativeGold
        {
            get { return _nativeGold; }
            set
            {
                if (value == _nativeGold) return;
                _nativeGold = value;
                OnPropertyChanged();
            }
        }

        public bool RawDiamond
        {
            get { return _rawDiamond; }
            set
            {
                if (value == _rawDiamond) return;
                _rawDiamond = value;
                OnPropertyChanged();
            }
        }

        public bool RawEmerald
        {
            get { return _rawEmerald; }
            set
            {
                if (value == _rawEmerald) return;
                _rawEmerald = value;
                OnPropertyChanged();
            }
        }

        public bool LuminiumOre
        {
            get { return _luminiumOre; }
            set
            {
                if (value == _luminiumOre) return;
                _luminiumOre = value;
                OnPropertyChanged();
            }
        }

        public bool BrownMushroom
        {
            get { return _brownMushroom; }
            set
            {
                if (value == _brownMushroom) return;
                _brownMushroom = value;
                OnPropertyChanged();
            }
        }

        public bool Cluster_5AM
        {
            get { return _cluster_5Am; }
            set
            {
                if (value == _cluster_5Am) return;
                _cluster_5Am = value;
                OnPropertyChanged();
            }
        }

        public bool ThanalanTopsoil3
        {
            get { return _thanalanTopsoil3; }
            set
            {
                if (value == _thanalanTopsoil3) return;
                _thanalanTopsoil3 = value;
                OnPropertyChanged();
            }
        }

        public bool GoldSand
        {
            get { return _goldSand; }
            set
            {
                if (value == _goldSand) return;
                _goldSand = value;
                OnPropertyChanged();
            }
        }

        public bool EbonyLog
        {
            get { return _ebonyLog; }
            set
            {
                if (value == _ebonyLog) return;
                _ebonyLog = value;
                OnPropertyChanged();
            }
        }

        public bool Trillium
        {
            get { return _trillium; }
            set
            {
                if (value == _trillium) return;
                _trillium = value;
                OnPropertyChanged();
            }
        }

        public bool HoneyLemon
        {
            get { return _honeyLemon; }
            set
            {
                if (value == _honeyLemon) return;
                _honeyLemon = value;
                OnPropertyChanged();
            }
        }

        public bool AstralMoraine
        {
            get { return _astralMoraine; }
            set
            {
                if (value == _astralMoraine) return;
                _astralMoraine = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_AstralMoraine
        {
            get { return _collectAstralMoraine; }
            set
            {
                if (value == _collectAstralMoraine) return;
                _collectAstralMoraine = value;
                OnPropertyChanged();
            }
        }

        public bool SunMica
        {
            get { return _sunMica; }
            set
            {
                if (value == _sunMica) return;
                _sunMica = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_SunMica
        {
            get { return _collectSunMica; }
            set
            {
                if (value == _collectSunMica) return;
                _collectSunMica = value;
                OnPropertyChanged();
            }
        }

        public bool AurumRegisOre
        {
            get { return _aurumRegisOre; }
            set
            {
                if (value == _aurumRegisOre) return;
                _aurumRegisOre = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_AurumRegisOre
        {
            get { return _collectAurumRegisOre; }
            set
            {
                if (value == _collectAurumRegisOre) return;
                _collectAurumRegisOre = value;
                OnPropertyChanged();
            }
        }

        public bool ThavnairianMistletoe_5
        {
            get { return _thavnairianMistletoe5; }
            set
            {
                if (value == _thavnairianMistletoe5) return;
                _thavnairianMistletoe5 = value;
                OnPropertyChanged();
            }
        }

        public bool VolcanicRockSalt_5
        {
            get { return _volcanicRockSalt5; }
            set
            {
                if (value == _volcanicRockSalt5) return;
                _volcanicRockSalt5 = value;
                OnPropertyChanged();
            }
        }

        public bool Rosemary
        {
            get { return _rosemary; }
            set
            {
                if (value == _rosemary) return;
                _rosemary = value;
                OnPropertyChanged();
            }
        }

        public bool Cluster_5PM
        {
            get { return _cluster_5Pm; }
            set
            {
                if (value == _cluster_5Pm) return;
                _cluster_5Pm = value;
                OnPropertyChanged();
            }
        }

        public bool VanillaBeans
        {
            get { return _vanillaBeans; }
            set
            {
                if (value == _vanillaBeans) return;
                _vanillaBeans = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_VanillaBeans
        {
            get { return _collectVanillaBeans; }
            set
            {
                if (value == _collectVanillaBeans) return;
                _collectVanillaBeans = value;
                OnPropertyChanged();
            }
        }

        public bool HoneydewAlmonds
        {
            get { return _honeydewAlmonds; }
            set
            {
                if (value == _honeydewAlmonds) return;
                _honeydewAlmonds = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_HoneydewAlmonds
        {
            get { return _collectHoneydewAlmonds; }
            set
            {
                if (value == _collectHoneydewAlmonds) return;
                _collectHoneydewAlmonds = value;
                OnPropertyChanged();
            }
        }

        public bool SeventhHeaven
        {
            get { return _seventhHeaven; }
            set
            {
                if (value == _seventhHeaven) return;
                _seventhHeaven = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_SeventhHeaven
        {
            get { return _collectSeventhHeaven; }
            set
            {
                if (value == _collectSeventhHeaven) return;
                _collectSeventhHeaven = value;
                OnPropertyChanged();
            }
        }

        public bool ZeoliteOre
        {
            get { return _zeoliteOre; }
            set
            {
                if (value == _zeoliteOre) return;
                _zeoliteOre = value;
                OnPropertyChanged();
            }
        }

        public bool RawRuby
        {
            get { return _rawRuby; }
            set
            {
                if (value == _rawRuby) return;
                _rawRuby = value;
                OnPropertyChanged();
            }
        }

        public bool RawSapphire
        {
            get { return _rawSapphire; }
            set
            {
                if (value == _rawSapphire) return;
                _rawSapphire = value;
                OnPropertyChanged();
            }
        }

        public bool Teaklog
        {
            get { return _teaklog; }
            set
            {
                if (value == _teaklog) return;
                _teaklog = value;
                OnPropertyChanged();
            }
        }

        public bool UmbralRock
        {
            get { return _umbralRock; }
            set
            {
                if (value == _umbralRock) return;
                _umbralRock = value;
                OnPropertyChanged();
            }
        }

        public bool RedolentLog
        {
            get { return _redolentLog; }
            set
            {
                if (value == _redolentLog) return;
                _redolentLog = value;
                OnPropertyChanged();
            }
        }

        public bool ShroudTopsoil3
        {
            get { return _shroudTopsoil3; }
            set
            {
                if (value == _shroudTopsoil3) return;
                _shroudTopsoil3 = value;
                OnPropertyChanged();
            }
        }

        public bool YoungCieldalaesSpinach
        {
            get { return _youngCieldalaesSpinach; }
            set
            {
                if (value == _youngCieldalaesSpinach) return;
                _youngCieldalaesSpinach = value;
                OnPropertyChanged();
            }
        }

        public bool VioletQuartz
        {
            get { return _violetQuartz; }
            set
            {
                if (value == _violetQuartz) return;
                _violetQuartz = value;
                OnPropertyChanged();
            }
        }

        public bool BlueQuartz
        {
            get { return _blueQuartz; }
            set
            {
                if (value == _blueQuartz) return;
                _blueQuartz = value;
                OnPropertyChanged();
            }
        }

        public bool RedAlumen
        {
            get { return _redAlumen; }
            set
            {
                if (value == _redAlumen) return;
                _redAlumen = value;
                OnPropertyChanged();
            }
        }

        public bool LaNosceanTopsoil3
        {
            get { return _laNosceanTopsoil3; }
            set
            {
                if (value == _laNosceanTopsoil3) return;
                _laNosceanTopsoil3 = value;
                OnPropertyChanged();
            }
        }

        public bool ThavnairianMistletoe_7
        {
            get { return _thavnairianMistletoe7; }
            set
            {
                if (value == _thavnairianMistletoe7) return;
                _thavnairianMistletoe7 = value;
                OnPropertyChanged();
            }
        }

        public bool VolcanicRockSalt_7
        {
            get { return _volcanicRockSalt7; }
            set
            {
                if (value == _volcanicRockSalt7) return;
                _volcanicRockSalt7 = value;
                OnPropertyChanged();
            }
        }

        public bool VirginBasiliskEgg
        {
            get { return _virginBasiliskEgg; }
            set
            {
                if (value == _virginBasiliskEgg) return;
                _virginBasiliskEgg = value;
                OnPropertyChanged();
            }
        }

        public bool DravanianPaprika
        {
            get { return _dravanianPaprika; }
            set
            {
                if (value == _dravanianPaprika) return;
                _dravanianPaprika = value;
                OnPropertyChanged();
            }
        }

        public bool WattleBark
        {
            get { return _wattleBark; }
            set
            {
                if (value == _wattleBark) return;
                _wattleBark = value;
                OnPropertyChanged();
            }
        }

        public bool Snurbleberry
        {
            get { return _snurbleberry; }
            set
            {
                if (value == _snurbleberry) return;
                _snurbleberry = value;
                OnPropertyChanged();
            }
        }

        public bool Tungstite
        {
            get { return _tungstite; }
            set
            {
                if (value == _tungstite) return;
                _tungstite = value;
                OnPropertyChanged();
            }
        }

        public bool LaNosceanLeek
        {
            get { return _laNosceanLeek; }
            set
            {
                if (value == _laNosceanLeek) return;
                _laNosceanLeek = value;
                OnPropertyChanged();
            }
        }

        public bool WaterfowlFeather
        {
            get { return _waterfowlFeather; }
            set
            {
                if (value == _waterfowlFeather) return;
                _waterfowlFeather = value;
                OnPropertyChanged();
            }
        }

        public bool NobleSage
        {
            get { return _nobleSage; }
            set
            {
                if (value == _nobleSage) return;
                _nobleSage = value;
                OnPropertyChanged();
            }
        }

        public bool Cluster_9AM
        {
            get { return _cluster_9Am; }
            set
            {
                if (value == _cluster_9Am) return;
                _cluster_9Am = value;
                OnPropertyChanged();
            }
        }

        public bool SpruceLog
        {
            get { return _spruceLog; }
            set
            {
                if (value == _spruceLog) return;
                _spruceLog = value;
                OnPropertyChanged();
            }
        }

        public bool GoldOre
        {
            get { return _goldOre; }
            set
            {
                if (value == _goldOre) return;
                _goldOre = value;
                OnPropertyChanged();
            }
        }

        public bool Apricot
        {
            get { return _apricot; }
            set
            {
                if (value == _apricot) return;
                _apricot = value;
                OnPropertyChanged();
            }
        }

        public bool PricklyPineapple
        {
            get { return _pricklyPineapple; }
            set
            {
                if (value == _pricklyPineapple) return;
                _pricklyPineapple = value;
                OnPropertyChanged();
            }
        }

        public bool PricklyPineappleSeeds
        {
            get { return _pricklyPineappleSeeds; }
            set
            {
                if (value == _pricklyPineappleSeeds) return;
                _pricklyPineappleSeeds = value;
                OnPropertyChanged();
            }
        }

        public bool Cluster_9PM
        {
            get { return _cluster_9Pm; }
            set
            {
                if (value == _cluster_9Pm) return;
                _cluster_9Pm = value;
                OnPropertyChanged();
            }
        }

        public bool Kidragora
        {
            get { return _kidragora; }
            set
            {
                if (value == _kidragora) return;
                _kidragora = value;
                OnPropertyChanged();
            }
        }

        public bool TrilliumBulb
        {
            get { return _trilliumBulb; }
            set
            {
                if (value == _trilliumBulb) return;
                _trilliumBulb = value;
                OnPropertyChanged();
            }
        }

        public bool Chysahl
        {
            get { return _chysahl; }
            set
            {
                if (value == _chysahl) return;
                _chysahl = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_Chysahl
        {
            get { return _collectChysahl; }
            set
            {
                if (value == _collectChysahl) return;
                _collectChysahl = value;
                OnPropertyChanged();
            }
        }

        public bool CypressLog
        {
            get { return _cypressLog; }
            set
            {
                if (value == _cypressLog) return;
                _cypressLog = value;
                OnPropertyChanged();
            }
        }

        public bool PearlSproutSeeds
        {
            get { return _pearlSproutSeeds; }
            set
            {
                if (value == _pearlSproutSeeds) return;
                _pearlSproutSeeds = value;
                OnPropertyChanged();
            }
        }

        public bool CoerthanTeaSeeds
        {
            get { return _coerthanTeaSeeds; }
            set
            {
                if (value == _coerthanTeaSeeds) return;
                _coerthanTeaSeeds = value;
                OnPropertyChanged();
            }
        }

        public bool Pyrite
        {
            get { return _pyrite; }
            set
            {
                if (value == _pyrite) return;
                _pyrite = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_Pyrite
        {
            get { return _collectPyrite; }
            set
            {
                if (value == _collectPyrite) return;
                _collectPyrite = value;
                OnPropertyChanged();
            }
        }

        public bool Chalcocite
        {
            get { return _chalcocite; }
            set
            {
                if (value == _chalcocite) return;
                _chalcocite = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_Chalcocite
        {
            get { return _collectChalcocite; }
            set
            {
                if (value == _collectChalcocite) return;
                _collectChalcocite = value;
                OnPropertyChanged();
            }
        }

        public bool Limonite
        {
            get { return _limonite; }
            set
            {
                if (value == _limonite) return;
                _limonite = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_Limonite
        {
            get { return _collectLimonite; }
            set
            {
                if (value == _collectLimonite) return;
                _collectLimonite = value;
                OnPropertyChanged();
            }
        }

        public bool CoerthanTeaLeaves
        {
            get { return _coerthanTeaLeaves; }
            set
            {
                if (value == _coerthanTeaLeaves) return;
                _coerthanTeaLeaves = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_CoerthanTeaLeaves
        {
            get { return _collectCoerthanTeaLeaves; }
            set
            {
                if (value == _collectCoerthanTeaLeaves) return;
                _collectCoerthanTeaLeaves = value;
                OnPropertyChanged();
            }
        }

        public bool PearlSprouts
        {
            get { return _pearlSprouts; }
            set
            {
                if (value == _pearlSprouts) return;
                _pearlSprouts = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_PearlSprouts
        {
            get { return _collectPearlSprouts; }
            set
            {
                if (value == _collectPearlSprouts) return;
                _collectPearlSprouts = value;
                OnPropertyChanged();
            }
        }

        public bool Chives
        {
            get { return _chives; }
            set
            {
                if (value == _chives) return;
                _chives = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_Chives
        {
            get { return _collectChives; }
            set
            {
                if (value == _collectChives) return;
                _collectChives = value;
                OnPropertyChanged();
            }
        }

        public bool HeavensLemon
        {
            get { return _heavensLemon; }
            set
            {
                if (value == _heavensLemon) return;
                _heavensLemon = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_HeavensLemon
        {
            get { return _collectHeavensLemon; }
            set
            {
                if (value == _collectHeavensLemon) return;
                _collectHeavensLemon = value;
                OnPropertyChanged();
            }
        }

        public bool AbalathianMistletoe
        {
            get { return _abalathianMistletoe; }
            set
            {
                if (value == _abalathianMistletoe) return;
                _abalathianMistletoe = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_AbalathianMistletoe
        {
            get { return _collectAbalathianMistletoe; }
            set
            {
                if (value == _collectAbalathianMistletoe) return;
                _collectAbalathianMistletoe = value;
                OnPropertyChanged();
            }
        }

        public bool Adamantite
        {
            get { return _adamantite; }
            set
            {
                if (value == _adamantite) return;
                _adamantite = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_Adamantite
        {
            get { return _collectAdamantite; }
            set
            {
                if (value == _collectAdamantite) return;
                _collectAdamantite = value;
                OnPropertyChanged();
            }
        }

        public bool StarCottonBoll
        {
            get { return _starCottonBoll; }
            set
            {
                if (value == _starCottonBoll) return;
                _starCottonBoll = value;
                OnPropertyChanged();
            }
        }

        public bool Porcini
        {
            get { return _porcini; }
            set
            {
                if (value == _porcini) return;
                _porcini = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_Porcini
        {
            get { return _collectPorcini; }
            set
            {
                if (value == _collectPorcini) return;
                _collectPorcini = value;
                OnPropertyChanged();
            }
        }

        public bool DravanianMistletoe
        {
            get { return _dravanianMistletoe; }
            set
            {
                if (value == _dravanianMistletoe) return;
                _dravanianMistletoe = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_DravanianMistletoe
        {
            get { return _collectDravanianMistletoe; }
            set
            {
                if (value == _collectDravanianMistletoe) return;
                _collectDravanianMistletoe = value;
                OnPropertyChanged();
            }
        }

        public bool CloudBanana
        {
            get { return _cloudBanana; }
            set
            {
                if (value == _cloudBanana) return;
                _cloudBanana = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_CloudBanana
        {
            get { return _collectCloudBanana; }
            set
            {
                if (value == _collectCloudBanana) return;
                _collectCloudBanana = value;
                OnPropertyChanged();
            }
        }

        public bool Morel
        {
            get { return _morel; }
            set
            {
                if (value == _morel) return;
                _morel = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_Morel
        {
            get { return _collectMorel; }
            set
            {
                if (value == _collectMorel) return;
                _collectMorel = value;
                OnPropertyChanged();
            }
        }

        public bool AbalathianRockSalt
        {
            get { return _abalathianRockSalt; }
            set
            {
                if (value == _abalathianRockSalt) return;
                _abalathianRockSalt = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_AbalathianRockSalt
        {
            get { return _collectAbalathianRockSalt; }
            set
            {
                if (value == _collectAbalathianRockSalt) return;
                _collectAbalathianRockSalt = value;
                OnPropertyChanged();
            }
        }

        public bool RedQuartz
        {
            get { return _redQuartz; }
            set
            {
                if (value == _redQuartz) return;
                _redQuartz = value;
                OnPropertyChanged();
            }
        }

        public bool Collect_RedQuartz
        {
            get { return _collectRedQuartz; }
            set
            {
                if (value == _collectRedQuartz) return;
                _collectRedQuartz = value;
                OnPropertyChanged();
            }
        }

        #endregion UNOWN
        
        private int _waitingAetheryteId;
        private bool _useHouseCodechunck;
        private bool _useAetheryteIdyllshire;
        private bool _tangela;
        private bool _onix;
        private bool _ditto;
        private bool _magikarp;
        private bool _psyduck;
        private bool _slowpoke;
        private bool _umbreon;
        private bool _snorlax;
        private bool _unown;
        private string _sandCollectRate1StarTangela;
        private bool _collectRadiantAstralMoraineTangela;
        private bool _collectLoversLaurelTangela;
        private string _sandCollectRateTangela;
        private bool _gatherHighlandOreganoTangela;
        private bool _gatherFurymintTangela;
        private bool _gatherBlackSoilTangela;
        private string _cordialTypeTangela;
        private string _cordialTimeTangela;
        private bool _btn04Tangela;
        private bool _btn48Tangela;
        private bool _min48Tangela;
        private bool _btn812Tangela;
        private bool _min812Tangela;
        private bool _min1216Tangela;
        private bool _btn1620Tangela;
        private bool _min1620Tangela;
        private bool _btn2024Tangela;
        private bool _min2024Tangela;
        private string _sandCollectRate1StarOnix;
        private bool _collectRadiantAstralMoraineOnix;
        private bool _collectLoversLaurelOnix;
        private string _sandCollectRateOnix;
        private bool _gatherHighlandOreganoOnix;
        private bool _gatherFurymintOnix;
        private bool _gatherBlackSoilOnix;
        private string _cordialTypeOnix;
        private string _cordialTimeOnix;
        private bool _btn04Onix;
        private bool _btn48Onix;
        private bool _min48Onix;
        private bool _btn812Onix;
        private bool _min812Onix;
        private bool _min1216Onix;
        private bool _btn1620Onix;
        private bool _min1620Onix;
        private bool _btn2024Onix;
        private bool _min2024Onix;
        private bool _disableRotationOverrideSnorlax;
        private string _gatherIncreaseSnorlax;
        private bool _spiritBondSnorlax;
        private int _rawCitrine;
        private int _iceCrystalRedRime;
        private int _abalathianSpringWater;
        private int _aurumRegisSand;
        private int _lightningCrystalVoorSianSiranMin;
        private int _waterCrystalVoorSianSiranMin;
        private int _beastkinHorn;
        private int _rawCarnelian;
        private int _rawOpal;
        private int _fireCrystalAvaloniaFallenMin;
        private int _lumythriteSand;
        private int _cloudMica;
        private int _hardsilverSand;
        private int _earthCrystalLandlordColonyMin;
        private int _hardsilverOre;
        private int _rawChrysolite;
        private int _wyrmObsidian;
        private int _windCrystalTheMakersQuarter;
        private int _mythriteSand;
        private int _iceCrystalTwinpoolsMin51;
        private int _mythriteOre;
        private int _rawLarimar;
        private int _rawMormorion;
        private int _iceCrystalGorganeHolding;
        private int _rawAgate;
        private int _rawTigersEye;
        private int _dravanianSpringWater;
        private int _fireCrystalTheSmolderingWastesMin;
        private int _titaniumOre;
        private int _rawStarRuby;
        private int _rawStarSapphire;
        private int _fireCrystalChocoboForestMin;
        private int _dragonObsidian;
        private int _iceCrystalRiversmeetMin;
        private int _whitefrostCottonBoll;
        private int _coriander;
        private int _rue;
        private int _iceCrystalTwinpoolsBtn56;
        private int _birchLog;
        private int _birchBranch;
        private int _birchSap;
        private int _waterCrystalVoorSianSiranBtn;
        private int _coneflower;
        private int _fireCrystalAvaloniaFallenBtn;
        private int _camphorwoodBranch;
        private int _camphorwoodLog;
        private int _dandelion;
        private int _earthCrystalFourArms;
        private int _cowBitter;
        private int _gaelicatnip;
        private int _windCrystalTheAnsweringQuarter;
        private int _rainbowCottonBoll;
        private int _sprigOfMistDill;
        private int _iceCrystalTwinpoolsBtn51;
        private int _darkChestnut;
        private int _darkChestnutLog;
        private int _darkChestnutBranch;
        private int _fireCrystalTheSmolderingWastesBtn;
        private int _cyclopsOnion;
        private int _highlandWheat;
        private int _stalkOfRamie;
        private int _fireCrystalChocoboForestBtn;
        private int _emeraldBeans;
        private int _magmaBeet;
        private int _earthCrystalLandlordColonyBtn;
        private int _cedarLog;
        private int _cedarBranch;
        private int _iceCrystalRiversmeetBtn;
        private int _bloodCurrants;
        private int _whiteTruffle;
        private int _aloe;
        private int _flax;
        private int _highlandParsley;
        private int _fireShardBtn;
        private int _fireCrystalBtn;
        private int _iceShardBtn;
        private int _iceCrystalBtn;
        private int _windShardBtn;
        private int _windCrystalBtn;
        private int _earthShardBtn;
        private int _earthCrystalBtn;
        private int _lightningShardBtn;
        private int _lightningCrystalBtn;
        private int _waterShardBtn;
        private int _waterCrystalBtn;
        private int _cobaltOre;
        private int _basiliskEgg;
        private int _electrumOre;
        private int _mythrilOre;
        private int _silverOre;
        private int _effervescentWater;
        private int _fireShardMin;
        private int _fireCrystalMin;
        private int _iceShardMin;
        private int _iceCrystalMin;
        private int _windShardMin;
        private int _windCrystalMin;
        private int _earthShardMin;
        private int _earthCrystalMin;
        private int _lightningShardMin;
        private int _lightningCrystalMin;
        private int _waterShardMin;
        private int _waterCrystalMin;
        private string _cordialTypeDitto;
        private string _cordialTimeDitto;
        private bool _dragonObsidianDitto;
        private string _dragonObsidianRateDitto;
        private bool _fossilizedDragonBoneDitto;
        private string _fossilizedDragonBoneRateDitto;
        private bool _tektiteDitto;
        private string _tektiteRateDitto;
        private bool _eventideJadeDitto;
        private string _eventideJadeRateDitto;
        private bool _cedarLogDitto;
        private string _cedarLogRateDitto;
        private bool _windWidowDitto;
        private string _windWidowRateDitto;
        private bool _cloudMushroomDitto;
        private string _cloudMushroomRateDitto;
        private bool _periwinkleDitto;
        private string _periwinkleRateDitto;
        private string _patiencePsyduck;
        private string _cordialTypePsyduck;
        private bool _keepFishingPsyduck;
        private bool _hraesvelgrsTearPsyduck;
        private bool _scaleripperPsyduck;
        private bool _theDreamweaverPsyduck;
        private bool _meteortoisePsyduck;
        private bool _vidofnirPsyduck;
        private bool _theSoulOfTheMartyrPsyduck;
        private bool _inkfishPsyduck;
        private bool _theSecondOnePsyduck;
        private bool _aphoticPirarucuPsyduck;
        private bool _amberSalamanderPsyduck;
        private bool _fleeceStingrayPsyduck;
        private bool _lavaSnailPsyduck;
        private bool _oliphantsTrunkPsyduck;
        private bool _armoredCatfishPsyduck;
        private bool _neptoDragonPsyduck;
        private bool _kunotheKillerPsyduck;
        private bool _shonisaurusPsyduck;
        private bool _helicoprionPsyduck;
        private bool _namitaroPsyduck;
        private bool _endocerasPsyduck;
        private bool _titanicSawfishPsyduck;
        private bool _navigatorsBrandPsyduck;
        private bool _frilledSharkPsyduck;
        private bool _ninjaBettaPsyduck;
        private bool _magicCarpetPsyduck;
        private bool _theGreatestBreamInTheWorldPsyduck;
        private bool _thunderboltEelPsyduck;
        private bool _dravanianBassPsyduck;
        private bool _pteranodonPsyduck;
        private bool _thaliakCaimanPsyduck;
        private bool _tupuxuaraPsyduck;
        private bool _caimanPsyduck;
        private bool _pipiraPiraPsyduck;
        private bool _isCheck;
        private bool _cluster_1Am;
        private bool _meteorite;
        private bool _smithsoniteOre;
        private bool _silkwormCocoon;
        private bool _darksteelOre;
        private bool _cluster_1Pm;
        private bool _frostCottonBoll;
        private bool _vampirePlant;
        private bool _fragrantLog;
        private bool _antumbralRock;
        private bool _blackTruffle;
        private bool _dzemaelTomato;
        private bool _dzemaelTomatoSeeds;
        private bool _oldWorldFigSeeds;
        private bool _oldWorldFig;
        private bool _collectOldWorldFig;
        private bool _yellowQuartz;
        private bool _collectYellowQuartz;
        private bool _greenQuartz;
        private bool _collectGreenQuartz;
        private bool _lightKidneyOre;
        private bool _collectLightKidneyOre;
        private bool _cuprite;
        private bool _collectCuprite;
        private bool _lumythriteOre;
        private bool _ferberite;
        private bool _rawTopaz;
        private bool _rawIolite;
        private bool _oldGrowthCamphorwoodLog;
        private bool _crystallizedSap;
        private bool _platinumOre;
        private bool _nativeGold;
        private bool _rawDiamond;
        private bool _rawEmerald;
        private bool _luminiumOre;
        private bool _brownMushroom;
        private bool _cluster_5Am;
        private bool _thanalanTopsoil3;
        private bool _goldSand;
        private bool _ebonyLog;
        private bool _trillium;
        private bool _honeyLemon;
        private bool _astralMoraine;
        private bool _collectAstralMoraine;
        private bool _sunMica;
        private bool _collectSunMica;
        private bool _aurumRegisOre;
        private bool _collectAurumRegisOre;
        private bool _thavnairianMistletoe5;
        private bool _volcanicRockSalt5;
        private bool _rosemary;
        private bool _cluster_5Pm;
        private bool _vanillaBeans;
        private bool _collectVanillaBeans;
        private bool _honeydewAlmonds;
        private bool _collectHoneydewAlmonds;
        private bool _seventhHeaven;
        private bool _collectSeventhHeaven;
        private bool _zeoliteOre;
        private bool _rawRuby;
        private bool _rawSapphire;
        private bool _teaklog;
        private bool _umbralRock;
        private bool _redolentLog;
        private bool _shroudTopsoil3;
        private bool _youngCieldalaesSpinach;
        private bool _violetQuartz;
        private bool _blueQuartz;
        private bool _redAlumen;
        private bool _laNosceanTopsoil3;
        private bool _thavnairianMistletoe7;
        private bool _volcanicRockSalt7;
        private bool _virginBasiliskEgg;
        private bool _dravanianPaprika;
        private bool _wattleBark;
        private bool _snurbleberry;
        private bool _tungstite;
        private bool _laNosceanLeek;
        private bool _waterfowlFeather;
        private bool _nobleSage;
        private bool _cluster_9Am;
        private bool _spruceLog;
        private bool _goldOre;
        private bool _apricot;
        private bool _pricklyPineapple;
        private bool _pricklyPineappleSeeds;
        private bool _cluster_9Pm;
        private bool _kidragora;
        private bool _trilliumBulb;
        private bool _chysahl;
        private bool _collectChysahl;
        private bool _cypressLog;
        private bool _pearlSproutSeeds;
        private bool _coerthanTeaSeeds;
        private bool _pyrite;
        private bool _collectPyrite;
        private bool _chalcocite;
        private bool _collectChalcocite;
        private bool _limonite;
        private bool _collectLimonite;
        private bool _coerthanTeaLeaves;
        private bool _collectCoerthanTeaLeaves;
        private bool _pearlSprouts;
        private bool _collectPearlSprouts;
        private bool _chives;
        private bool _collectChives;
        private bool _heavensLemon;
        private bool _collectHeavensLemon;
        private bool _abalathianMistletoe;
        private bool _collectAbalathianMistletoe;
        private bool _adamantite;
        private bool _collectAdamantite;
        private bool _starCottonBoll;
        private bool _porcini;
        private bool _collectPorcini;
        private bool _dravanianMistletoe;
        private bool _collectDravanianMistletoe;
        private bool _cloudBanana;
        private bool _collectCloudBanana;
        private bool _morel;
        private bool _collectMorel;
        private bool _abalathianRockSalt;
        private bool _collectAbalathianRockSalt;
        private bool _redQuartz;
        private bool _collectRedQuartz;
        private string _gatherIncrease5060;
        private string _gatherIncrease1Star;
        private string _gatherIncrease1StarPlus;
        private string _gatherIncrease3Star;
        private bool _disableRotationOverride5060;
        private bool _disableRotationOverride1Star;
        private bool _disableRotationOverride1StarPlus;
        private bool _disableRotationOverride3Star;

        public bool LoadCurrentFile()
        {
            string text = File.ReadAllText(GlobalDataManager.Instance.FilePath);
            if (!text.Contains("<!ENTITY Version \"Umbreon\">"))
                return false;

            IsCheck = false;

            XmlDocument doc = new XmlDocument();
            doc.Load(GlobalDataManager.Instance.FilePath);

            XmlNamedNodeMap nMap = doc.DocumentType.Entities;
            DisplayEntities(nMap);
            IsCheck = true;
            return true;
        }

        public void DisplayEntities(XmlNamedNodeMap nMap)
        {
            for (int i = 0; i < nMap.Count; i++)
            {
                XmlEntity ent = (XmlEntity)nMap.Item(i);
                FillModelWithValue(ent.Name, ent.InnerText);
            }
        }

        public void FillModelWithValue(string property, string value)
        {
            // General
            if (property.Equals("WaitAtWaitingLocation"))
                WaitAtWaitingLocation = GetBooleanValue(value);
            else if (property.Equals("Waiting_AetheryteId"))
                Waiting_AetheryteId = GetIntValue(value);
            else if (property.Equals("Use_House_Codechunck"))
                Use_House_Codechunck = GetBooleanValue(value);
            else if (property.Equals("Use_Aetheryte_Idyllshire"))
                Use_Aetheryte_Idyllshire = GetBooleanValue(value);
            else if (property.Equals("Tangela"))
                Tangela = GetBooleanValue(value);
            else if (property.Equals("Onix"))
                Onix = GetBooleanValue(value);
            else if (property.Equals("Ditto"))
                Ditto = GetBooleanValue(value);
            else if (property.Equals("Magikarp"))
                Magikarp = GetBooleanValue(value);
            else if (property.Equals("Psyduck"))
                Psyduck = GetBooleanValue(value);
            else if (property.Equals("Slowpoke"))
                Slowpoke = GetBooleanValue(value);
            else if (property.Equals("Umbreon"))
                Umbreon = GetBooleanValue(value);
            else if (property.Equals("Snorlax"))
                Snorlax = GetBooleanValue(value);
            else if (property.Equals("Unown"))
                Unown = GetBooleanValue(value);

            // Tangela
            else if (property.Equals("Sand_Collect_Rate_1Star_Tangela"))
                Sand_Collect_Rate_1Star_Tangela = value;
            else if (property.Equals("Collect_RadiantAstralMoraine_Tangela"))
                Collect_RadiantAstralMoraine_Tangela = GetBooleanValue(value);
            else if (property.Equals("Collect_LoversLaurel_Tangela"))
                Collect_LoversLaurel_Tangela = GetBooleanValue(value);

            else if (property.Equals("Sand_Collect_Rate_Tangela"))
                Sand_Collect_Rate_Tangela = value;
            else if (property.Equals("Gather_HighlandOregano_Tangela"))
                Gather_HighlandOregano_Tangela = GetBooleanValue(value);
            else if (property.Equals("Gather_Furymint_Tangela"))
                Gather_Furymint_Tangela = GetBooleanValue(value);
            else if (property.Equals("Gather_BlackSoil_Tangela"))
                Gather_BlackSoil_Tangela = GetBooleanValue(value);

            else if (property.Equals("CordialType_Tangela"))
                CordialType_Tangela = value;
            else if (property.Equals("CordialType_Tangela"))
                CordialType_Tangela = value;

            else if (property.Equals("BTN_0_4_Tangela"))
                BTN_0_4_Tangela = GetBooleanValue(value);
            else if (property.Equals("BTN_4_8_Tangela"))
                BTN_4_8_Tangela = GetBooleanValue(value);
            else if (property.Equals("MIN_4_8_Tangela"))
                MIN_4_8_Tangela = GetBooleanValue(value);
            else if (property.Equals("BTN_8_12_Tangela"))
                BTN_8_12_Tangela = GetBooleanValue(value);
            else if (property.Equals("MIN_8_12_Tangela"))
                MIN_8_12_Tangela = GetBooleanValue(value);
            else if (property.Equals("MIN_12_16_Tangela"))
                MIN_12_16_Tangela = GetBooleanValue(value);
            else if (property.Equals("BTN_16_20_Tangela"))
                BTN_16_20_Tangela = GetBooleanValue(value);
            else if (property.Equals("MIN_16_20_Tangela"))
                MIN_16_20_Tangela = GetBooleanValue(value);
            else if (property.Equals("BTN_20_24_Tangela"))
                BTN_20_24_Tangela = GetBooleanValue(value);
            else if (property.Equals("MIN_20_24_Tangela"))
                MIN_20_24_Tangela = GetBooleanValue(value);

            // Onix
            else if (property.Equals("Sand_Collect_Rate_1Star_Onix"))
                Sand_Collect_Rate_1Star_Onix = value;
            else if (property.Equals("Collect_RadiantAstralMoraine_Onix"))
                Collect_RadiantAstralMoraine_Onix = GetBooleanValue(value);
            else if (property.Equals("Collect_LoversLaurel_Onix"))
                Collect_LoversLaurel_Onix = GetBooleanValue(value);

            else if (property.Equals("Sand_Collect_Rate_Onix"))
                Sand_Collect_Rate_Onix = value;
            else if (property.Equals("Gather_HighlandOregano_Onix"))
                Gather_HighlandOregano_Onix = GetBooleanValue(value);
            else if (property.Equals("Gather_Furymint_Onix"))
                Gather_Furymint_Onix = GetBooleanValue(value);
            else if (property.Equals("Gather_BlackSoil_Onix"))
                Gather_BlackSoil_Onix = GetBooleanValue(value);

            else if (property.Equals("CordialType_Onix"))
                CordialType_Onix = value;
            else if (property.Equals("CordialTime_Onix"))
                CordialTime_Onix = value;

            else if (property.Equals("BTN_0_4_Onix"))
                BTN_0_4_Onix = GetBooleanValue(value);
            else if (property.Equals("BTN_4_8_Onix"))
                BTN_4_8_Onix = GetBooleanValue(value);
            else if (property.Equals("MIN_4_8_Onix"))
                MIN_4_8_Onix = GetBooleanValue(value);
            else if (property.Equals("BTN_8_12_Onix"))
                BTN_8_12_Onix = GetBooleanValue(value);
            else if (property.Equals("MIN_8_12_Onix"))
                MIN_8_12_Onix = GetBooleanValue(value);
            else if (property.Equals("MIN_12_16_Onix"))
                MIN_12_16_Onix = GetBooleanValue(value);
            else if (property.Equals("BTN_16_20_Onix"))
                BTN_16_20_Onix = GetBooleanValue(value);
            else if (property.Equals("MIN_16_20_Onix"))
                MIN_16_20_Onix = GetBooleanValue(value);
            else if (property.Equals("BTN_20_24_Onix"))
                BTN_20_24_Onix = GetBooleanValue(value);
            else if (property.Equals("MIN_20_24_Onix"))
                MIN_20_24_Onix = GetBooleanValue(value);

            // Ditto
            else if (property.Equals("DragonObsidian_Ditto"))
                DragonObsidian_Ditto = GetBooleanValue(value);
            else if (property.Equals("DragonObsidian_Rate_Ditto"))
                DragonObsidian_Rate_Ditto = value;

            else if (property.Equals("FossilizedDragonBone_Ditto"))
                FossilizedDragonBone_Ditto = GetBooleanValue(value);
            else if (property.Equals("FossilizedDragonBone_Rate_Ditto"))
                FossilizedDragonBone_Rate_Ditto = value;

            else if (property.Equals("Tektite_Ditto"))
                Tektite_Ditto = GetBooleanValue(value);
            else if (property.Equals("Tektite_Rate_Ditto"))
                Tektite_Rate_Ditto = value;

            else if (property.Equals("EventideJade_Ditto"))
                EventideJade_Ditto = GetBooleanValue(value);
            else if (property.Equals("EventideJade_Rate_Ditto"))
                EventideJade_Rate_Ditto = value;

            else if (property.Equals("CedarLog_Ditto"))
                CedarLog_Ditto = GetBooleanValue(value);
            else if (property.Equals("CedarLog_Rate_Ditto"))
                CedarLog_Rate_Ditto = value;

            else if (property.Equals("WindWidow_Ditto"))
                WindWidow_Ditto = GetBooleanValue(value);
            else if (property.Equals("WindWidow_Rate_Ditto"))
                WindWidow_Rate_Ditto = value;

            else if (property.Equals("CloudMushroom_Ditto"))
                CloudMushroom_Ditto = GetBooleanValue(value);
            else if (property.Equals("CloudMushroom_Rate_Ditto"))
                CloudMushroom_Rate_Ditto = value;

            else if (property.Equals("Periwinkle_Ditto"))
                Periwinkle_Ditto = GetBooleanValue(value);
            else if (property.Equals("Periwinkle_Rate_Ditto"))
                Periwinkle_Rate_Ditto = value;

            // Magikarp
            // TODO

            // Psyduck
            else if (property.Equals("Patience_Psyduck"))
                Patience_Psyduck = value;
            else if (property.Equals("CordialType_Psyduck"))
                CordialType_Psyduck = value;
            else if (property.Equals("KeepFishing_Psyduck"))
                KeepFishing_Psyduck = GetBooleanValue(value);

            else if (property.Equals("HraesvelgrsTear_Psyduck"))
                HraesvelgrsTear_Psyduck = GetBooleanValue(value);

            else if (property.Equals("Scaleripper_Psyduck"))
                Scaleripper_Psyduck = GetBooleanValue(value);
            else if (property.Equals("TheDreamweaver_Psyduck"))
                TheDreamweaver_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Meteortoise_Psyduck"))
                Meteortoise_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Vidofnir_Psyduck"))
                Vidofnir_Psyduck = GetBooleanValue(value);
            else if (property.Equals("TheSoulOfTheMartyr_Psyduck"))
                TheSoulOfTheMartyr_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Inkfish_Psyduck"))
                Inkfish_Psyduck = GetBooleanValue(value);
            else if (property.Equals("TheSecondOne_Psyduck"))
                TheSecondOne_Psyduck = GetBooleanValue(value);
            else if (property.Equals("AphoticPirarucu_Psyduck"))
                AphoticPirarucu_Psyduck = GetBooleanValue(value);

            else if (property.Equals("AmberSalamander_Psyduck"))
                AmberSalamander_Psyduck = GetBooleanValue(value);
            else if (property.Equals("FleeceStingray_Psyduck"))
                FleeceStingray_Psyduck = GetBooleanValue(value);
            else if (property.Equals("LavaSnail_Psyduck"))
                LavaSnail_Psyduck = GetBooleanValue(value);
            else if (property.Equals("OliphantsTrunk_Psyduck"))
                OliphantsTrunk_Psyduck = GetBooleanValue(value);
            else if (property.Equals("ArmoredCatfish_Psyduck"))
                ArmoredCatfish_Psyduck = GetBooleanValue(value);

            else if (property.Equals("NeptoDragon_Psyduck"))
                NeptoDragon_Psyduck = GetBooleanValue(value);
            else if (property.Equals("KunotheKiller_Psyduck"))
                KunotheKiller_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Shonisaurus_Psyduck"))
                Shonisaurus_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Helicoprion_Psyduck"))
                Helicoprion_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Namitaro_Psyduck"))
                Namitaro_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Endoceras_Psyduck"))
                Endoceras_Psyduck = GetBooleanValue(value);

            else if (property.Equals("TitanicSawfish_Psyduck"))
                TitanicSawfish_Psyduck = GetBooleanValue(value);
            else if (property.Equals("NavigatorsBrand_Psyduck"))
                NavigatorsBrand_Psyduck = GetBooleanValue(value);

            else if (property.Equals("FrilledShark_Psyduck"))
                FrilledShark_Psyduck = GetBooleanValue(value);
            else if (property.Equals("NinjaBetta_Psyduck"))
                NinjaBetta_Psyduck = GetBooleanValue(value);
            else if (property.Equals("MagicCarpet_Psyduck"))
                MagicCarpet_Psyduck = GetBooleanValue(value);
            else if (property.Equals("TheGreatestBreamInTheWorld_Psyduck"))
                TheGreatestBreamInTheWorld_Psyduck = GetBooleanValue(value);

            else if (property.Equals("ThunderboltEel_Psyduck"))
                ThunderboltEel_Psyduck = GetBooleanValue(value);

            else if (property.Equals("DravanianBass_Psyduck"))
                DravanianBass_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Pteranodon_Psyduck"))
                Pteranodon_Psyduck = GetBooleanValue(value);
            else if (property.Equals("ThaliakCaiman_Psyduck"))
                ThaliakCaiman_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Tupuxuara_Psyduck"))
                Tupuxuara_Psyduck = GetBooleanValue(value);
            else if (property.Equals("Caiman_Psyduck"))
                Caiman_Psyduck = GetBooleanValue(value);

            else if (property.Equals("PipiraPira_Psyduck"))
                PipiraPira_Psyduck = GetBooleanValue(value);

            // Slowpoke
            // TODO

            // Umbreon
            // TODO

            // Unown
            else if (property.Equals("GatherIncrease_50_60"))
                GatherIncrease_50_60 = value;
            else if (property.Equals("GatherIncrease_1Star"))
                GatherIncrease_1Star = value;
            else if (property.Equals("GatherIncrease_1StarPlus"))
                GatherIncrease_1StarPlus = value;
            else if (property.Equals("GatherIncrease_3Star"))
                GatherIncrease_3Star = value;
            else if (property.Equals("DisableRotationOverride_50_60"))
                DisableRotationOverride_50_60 = GetBooleanValue(value);
            else if (property.Equals("DisableRotationOverride_1Star"))
                DisableRotationOverride_1Star = GetBooleanValue(value);
            else if (property.Equals("DisableRotationOverride_1StarPlus"))
                DisableRotationOverride_1StarPlus = GetBooleanValue(value);
            else if (property.Equals("DisableRotationOverride_3Star"))
                DisableRotationOverride_3Star = GetBooleanValue(value);

            else if (property.Equals("Cluster_1AM"))
                Cluster_1AM = GetBooleanValue(value);
            else if (property.Equals("Meteorite"))
                Meteorite = GetBooleanValue(value);
            else if (property.Equals("SmithsoniteOre"))
                SmithsoniteOre = GetBooleanValue(value);
            else if (property.Equals("SilkwormCocoon"))
                SilkwormCocoon = GetBooleanValue(value);
            else if (property.Equals("DarksteelOre"))
                DarksteelOre = GetBooleanValue(value);
            else if (property.Equals("Cluster_1PM"))
                Cluster_1PM = GetBooleanValue(value);
            else if (property.Equals("FrostCottonBoll"))
                FrostCottonBoll = GetBooleanValue(value);
            else if (property.Equals("VampirePlant"))
                VampirePlant = GetBooleanValue(value);
            else if (property.Equals("FragrantLog"))
                FragrantLog = GetBooleanValue(value);
            else if (property.Equals("AntumbralRock"))
                AntumbralRock = GetBooleanValue(value);
            else if (property.Equals("BlackTruffle"))
                BlackTruffle = GetBooleanValue(value);
            else if (property.Equals("DzemaelTomato"))
                DzemaelTomato = GetBooleanValue(value);
            else if (property.Equals("DzemaelTomatoSeeds"))
                DzemaelTomatoSeeds = GetBooleanValue(value);

            else if (property.Equals("OldWorldFigSeeds"))
                OldWorldFigSeeds = GetBooleanValue(value);
            else if (property.Equals("OldWorldFig"))
                OldWorldFig = GetBooleanValue(value);
            else if (property.Equals("Collect_OldWorldFig"))
                Collect_OldWorldFig = GetBooleanValue(value);
            else if (property.Equals("YellowQuartz"))
                YellowQuartz = GetBooleanValue(value);
            else if (property.Equals("Collect_YellowQuartz"))
                Collect_YellowQuartz = GetBooleanValue(value);
            else if (property.Equals("GreenQuartz"))
                GreenQuartz = GetBooleanValue(value);
            else if (property.Equals("Collect_GreenQuartz"))
                Collect_GreenQuartz = GetBooleanValue(value);
            else if (property.Equals("LightKidneyOre"))
                LightKidneyOre = GetBooleanValue(value);
            else if (property.Equals("Collect_LightKidneyOre"))
                Collect_LightKidneyOre = GetBooleanValue(value);
            else if (property.Equals("Cuprite"))
                Cuprite = GetBooleanValue(value);
            else if (property.Equals("Collect_Cuprite"))
                Collect_Cuprite = GetBooleanValue(value);

            else if (property.Equals("LumythriteOre"))
                LumythriteOre = GetBooleanValue(value);
            else if (property.Equals("Ferberite"))
                Ferberite = GetBooleanValue(value);
            else if (property.Equals("RawTopaz"))
                RawTopaz = GetBooleanValue(value);
            else if (property.Equals("RawIolite"))
                RawIolite = GetBooleanValue(value);
            else if (property.Equals("OldGrowthCamphorwoodLog"))
                OldGrowthCamphorwoodLog = GetBooleanValue(value);
            else if (property.Equals("CrystallizedSap"))
                CrystallizedSap = GetBooleanValue(value);

            else if (property.Equals("PlatinumOre"))
                PlatinumOre = GetBooleanValue(value);
            else if (property.Equals("NativeGold"))
                NativeGold = GetBooleanValue(value);
            else if (property.Equals("RawDiamond"))
                RawDiamond = GetBooleanValue(value);
            else if (property.Equals("RawEmerald"))
                RawEmerald = GetBooleanValue(value);
            else if (property.Equals("LuminiumOre"))
                LuminiumOre = GetBooleanValue(value);
            else if (property.Equals("BrownMushroom"))
                BrownMushroom = GetBooleanValue(value);

            else if (property.Equals("Cluster_5AM"))
                Cluster_5AM = GetBooleanValue(value);
            else if (property.Equals("ThanalanTopsoil3"))
                ThanalanTopsoil3 = GetBooleanValue(value);
            else if (property.Equals("GoldSand"))
                GoldSand = GetBooleanValue(value);
            else if (property.Equals("EbonyLog"))
                EbonyLog = GetBooleanValue(value);
            else if (property.Equals("Trillium"))
                Trillium = GetBooleanValue(value);
            else if (property.Equals("HoneyLemon"))
                HoneyLemon = GetBooleanValue(value);
            else if (property.Equals("AstralMoraine"))
                AstralMoraine = GetBooleanValue(value);
            else if (property.Equals("Collect_AstralMoraine"))
                Collect_AstralMoraine = GetBooleanValue(value);
            else if (property.Equals("SunMica"))
                SunMica = GetBooleanValue(value);
            else if (property.Equals("Collect_SunMica"))
                Collect_SunMica = GetBooleanValue(value);
            else if (property.Equals("AurumRegisOre"))
                AurumRegisOre = GetBooleanValue(value);
            else if (property.Equals("Collect_AurumRegisOre"))
                Collect_AurumRegisOre = GetBooleanValue(value);

            else if (property.Equals("ThavnairianMistletoe_5"))
                ThavnairianMistletoe_5 = GetBooleanValue(value);
            else if (property.Equals("VolcanicRockSalt_5"))
                VolcanicRockSalt_5 = GetBooleanValue(value);
            else if (property.Equals("Rosemary"))
                Rosemary = GetBooleanValue(value);
            else if (property.Equals("Cluster_5PM"))
                Cluster_5PM = GetBooleanValue(value);
            else if (property.Equals("VanillaBeans"))
                VanillaBeans = GetBooleanValue(value);
            else if (property.Equals("Collect_VanillaBeans"))
                Collect_VanillaBeans = GetBooleanValue(value);
            else if (property.Equals("HoneydewAlmonds"))
                HoneydewAlmonds = GetBooleanValue(value);
            else if (property.Equals("Collect_HoneydewAlmonds"))
                Collect_HoneydewAlmonds = GetBooleanValue(value);
            else if (property.Equals("SeventhHeaven"))
                SeventhHeaven = GetBooleanValue(value);
            else if (property.Equals("Collect_SeventhHeaven"))
                Collect_SeventhHeaven = GetBooleanValue(value);

            else if (property.Equals("ZeoliteOre"))
                ZeoliteOre = GetBooleanValue(value);
            else if (property.Equals("RawRuby"))
                RawRuby = GetBooleanValue(value);
            else if (property.Equals("RawSapphire"))
                RawSapphire = GetBooleanValue(value);
            else if (property.Equals("Teaklog"))
                Teaklog = GetBooleanValue(value);

            else if (property.Equals("UmbralRock"))
                UmbralRock = GetBooleanValue(value);
            else if (property.Equals("RedolentLog"))
                RedolentLog = GetBooleanValue(value);
            else if (property.Equals("ShroudTopsoil3"))
                ShroudTopsoil3 = GetBooleanValue(value);
            else if (property.Equals("YoungCieldalaesSpinach"))
                YoungCieldalaesSpinach = GetBooleanValue(value);
            else if (property.Equals("VioletQuartz"))
                VioletQuartz = GetBooleanValue(value);
            else if (property.Equals("BlueQuartz"))
                BlueQuartz = GetBooleanValue(value);
            else if (property.Equals("RedAlumen"))
                RedAlumen = GetBooleanValue(value);

            else if (property.Equals("LaNosceanTopsoil3"))
                LaNosceanTopsoil3 = GetBooleanValue(value);
            else if (property.Equals("ThavnairianMistletoe_7"))
                ThavnairianMistletoe_7 = GetBooleanValue(value);
            else if (property.Equals("VolcanicRockSalt_7"))
                VolcanicRockSalt_7 = GetBooleanValue(value);
            else if (property.Equals("VirginBasiliskEgg"))
                VirginBasiliskEgg = GetBooleanValue(value);
            else if (property.Equals("DravanianPaprika"))
                DravanianPaprika = GetBooleanValue(value);
            else if (property.Equals("WattleBark"))
                WattleBark = GetBooleanValue(value);
            else if (property.Equals("Snurbleberry"))
                Snurbleberry = GetBooleanValue(value);

            else if (property.Equals("Tungstite"))
                Tungstite = GetBooleanValue(value);
            else if (property.Equals("LaNosceanLeek"))
                LaNosceanLeek = GetBooleanValue(value);
            else if (property.Equals("WaterfowlFeather"))
                WaterfowlFeather = GetBooleanValue(value);
            else if (property.Equals("NobleSage"))
                NobleSage = GetBooleanValue(value);

            else if (property.Equals("Cluster_9AM"))
                Cluster_9AM = GetBooleanValue(value);
            else if (property.Equals("SpruceLog"))
                SpruceLog = GetBooleanValue(value);
            else if (property.Equals("GoldOre"))
                GoldOre = GetBooleanValue(value);
            else if (property.Equals("Apricot"))
                Apricot = GetBooleanValue(value);
            else if (property.Equals("PricklyPineapple"))
                PricklyPineapple = GetBooleanValue(value);
            else if (property.Equals("PricklyPineappleSeeds"))
                PricklyPineappleSeeds = GetBooleanValue(value);

            else if (property.Equals("Cluster_9PM"))
                Cluster_9PM = GetBooleanValue(value);
            else if (property.Equals("Kidragora"))
                Kidragora = GetBooleanValue(value);
            else if (property.Equals("TrilliumBulb"))
                TrilliumBulb = GetBooleanValue(value);
            else if (property.Equals("Chysahl"))
                Chysahl = GetBooleanValue(value);
            else if (property.Equals("Collect_Chysahl"))
                Collect_Chysahl = GetBooleanValue(value);

            else if (property.Equals("CypressLog"))
                CypressLog = GetBooleanValue(value);

            else if (property.Equals("PearlSproutSeeds"))
                PearlSproutSeeds = GetBooleanValue(value);
            else if (property.Equals("CoerthanTeaSeeds"))
                CoerthanTeaSeeds = GetBooleanValue(value);
            else if (property.Equals("Pyrite"))
                Pyrite = GetBooleanValue(value);
            else if (property.Equals("Collect_Pyrite"))
                Collect_Pyrite = GetBooleanValue(value);
            else if (property.Equals("Chalcocite"))
                Chalcocite = GetBooleanValue(value);
            else if (property.Equals("Collect_Chalcocite"))
                Collect_Chalcocite = GetBooleanValue(value);
            else if (property.Equals("Limonite"))
                Limonite = GetBooleanValue(value);
            else if (property.Equals("Collect_Limonite"))
                Collect_Limonite = GetBooleanValue(value);

            else if (property.Equals("CoerthanTeaLeaves"))
                CoerthanTeaLeaves = GetBooleanValue(value);
            else if (property.Equals("Collect_CoerthanTeaLeaves"))
                Collect_CoerthanTeaLeaves = GetBooleanValue(value);
            else if (property.Equals("PearlSprouts"))
                PearlSprouts = GetBooleanValue(value);
            else if (property.Equals("Collect_PearlSprouts"))
                Collect_PearlSprouts = GetBooleanValue(value);
            else if (property.Equals("Chives"))
                Chives = GetBooleanValue(value);
            else if (property.Equals("Collect_Chives"))
                Collect_Chives = GetBooleanValue(value);
            else if (property.Equals("HeavensLemon"))
                HeavensLemon = GetBooleanValue(value);
            else if (property.Equals("Collect_HeavensLemon"))
                Collect_HeavensLemon = GetBooleanValue(value);
            else if (property.Equals("AbalathianMistletoe"))
                AbalathianMistletoe = GetBooleanValue(value);
            else if (property.Equals("Collect_AbalathianMistletoe"))
                Collect_AbalathianMistletoe = GetBooleanValue(value);

            else if (property.Equals("Adamantite"))
                Adamantite = GetBooleanValue(value);
            else if (property.Equals("Collect_Adamantite"))
                Collect_Adamantite = GetBooleanValue(value);

            else if (property.Equals("StarCottonBoll"))
                StarCottonBoll = GetBooleanValue(value);

            else if (property.Equals("Porcini"))
                Porcini = GetBooleanValue(value);
            else if (property.Equals("Collect_Porcini"))
                Collect_Porcini = GetBooleanValue(value);
            else if (property.Equals("DravanianMistletoe"))
                DravanianMistletoe = GetBooleanValue(value);
            else if (property.Equals("Collect_DravanianMistletoe"))
                Collect_DravanianMistletoe = GetBooleanValue(value);
            else if (property.Equals("CloudBanana"))
                CloudBanana = GetBooleanValue(value);
            else if (property.Equals("Collect_CloudBanana"))
                Collect_CloudBanana = GetBooleanValue(value);
            else if (property.Equals("Morel"))
                Morel = GetBooleanValue(value);
            else if (property.Equals("Collect_Morel"))
                Collect_Morel = GetBooleanValue(value);
            else if (property.Equals("AbalathianRockSalt"))
                AbalathianRockSalt = GetBooleanValue(value);
            else if (property.Equals("Collect_AbalathianRockSalt"))
                Collect_AbalathianRockSalt = GetBooleanValue(value);
            else if (property.Equals("RedQuartz"))
                RedQuartz = GetBooleanValue(value);
            else if (property.Equals("Collect_RedQuartz"))
                Collect_RedQuartz = GetBooleanValue(value);

            // Snorlax
            else if (property.Equals("DisableRotationOverride_Snorlax"))
                DisableRotationOverride_Snorlax = GetBooleanValue(value);
            else if (property.Equals("GatherIncrease_Snorlax"))
                GatherIncrease_Snorlax = value;
            else if (property.Equals("SpiritBond_Snorlax"))
                SpiritBond_Snorlax = GetBooleanValue(value);

            else if (property.Equals("RawCitrine"))
                RawCitrine = GetIntValue(value);
            else if (property.Equals("IceCrystal_RedRime"))
                IceCrystal_RedRime = GetIntValue(value);

            else if (property.Equals("AbalathianSpringWater"))
                AbalathianSpringWater = GetIntValue(value);
            else if (property.Equals("AurumRegisSand"))
                AurumRegisSand = GetIntValue(value);
            else if (property.Equals("LightningCrystal_VoorSianSiran_MIN"))
                LightningCrystal_VoorSianSiran_MIN = GetIntValue(value);
            else if (property.Equals("WaterCrystal_VoorSianSiran_MIN"))
                WaterCrystal_VoorSianSiran_MIN = GetIntValue(value);

            else if (property.Equals("BeastkinHorn"))
                BeastkinHorn = GetIntValue(value);
            else if (property.Equals("RawCarnelian"))
                RawCarnelian = GetIntValue(value);
            else if (property.Equals("RawOpal"))
                RawOpal = GetIntValue(value);
            else if (property.Equals("FireCrystal_AvaloniaFallen_MIN"))
                FireCrystal_AvaloniaFallen_MIN = GetIntValue(value);

            else if (property.Equals("LumythriteSand"))
                LumythriteSand = GetIntValue(value);
            else if (property.Equals("CloudMica"))
                CloudMica = GetIntValue(value);
            else if (property.Equals("HardsilverSand"))
                HardsilverSand = GetIntValue(value);
            else if (property.Equals("EarthCrystal_LandlordColony_MIN"))
                EarthCrystal_LandlordColony_MIN = GetIntValue(value);

            else if (property.Equals("HardsilverOre"))
                HardsilverOre = GetIntValue(value);
            else if (property.Equals("RawChrysolite"))
                RawChrysolite = GetIntValue(value);
            else if (property.Equals("WyrmObsidian"))
                WyrmObsidian = GetIntValue(value);
            else if (property.Equals("WindCrystal_TheMakersQuarter"))
                WindCrystal_TheMakersQuarter = GetIntValue(value);

            else if (property.Equals("MythriteSand"))
                MythriteSand = GetIntValue(value);
            else if (property.Equals("IceCrystal_Twinpools_MIN51"))
                IceCrystal_Twinpools_MIN51 = GetIntValue(value);

            else if (property.Equals("MythriteOre"))
                MythriteOre = GetIntValue(value);
            else if (property.Equals("RawLarimar"))
                RawLarimar = GetIntValue(value);
            else if (property.Equals("RawMormorion"))
                RawMormorion = GetIntValue(value);
            else if (property.Equals("IceCrystal_GorganeHolding"))
                IceCrystal_GorganeHolding = GetIntValue(value);

            else if (property.Equals("RawAgate"))
                RawAgate = GetIntValue(value);
            else if (property.Equals("RawTigersEye"))
                RawTigersEye = GetIntValue(value);
            else if (property.Equals("DravanianSpringWater"))
                DravanianSpringWater = GetIntValue(value);
            else if (property.Equals("FireCrystal_TheSmolderingWastes_MIN"))
                FireCrystal_TheSmolderingWastes_MIN = GetIntValue(value);

            else if (property.Equals("TitaniumOre"))
                TitaniumOre = GetIntValue(value);
            else if (property.Equals("RawStarRuby"))
                RawStarRuby = GetIntValue(value);
            else if (property.Equals("RawStarSapphire"))
                RawStarSapphire = GetIntValue(value);
            else if (property.Equals("FireCrystal_ChocoboForest_MIN"))
                FireCrystal_ChocoboForest_MIN = GetIntValue(value);

            else if (property.Equals("DragonObsidian"))
                DragonObsidian = GetIntValue(value);
            else if (property.Equals("IceCrystal_Riversmeet_MIN"))
                IceCrystal_Riversmeet_MIN = GetIntValue(value);

            else if (property.Equals("WhitefrostCottonBoll"))
                WhitefrostCottonBoll = GetIntValue(value);
            else if (property.Equals("Coriander"))
                Coriander = GetIntValue(value);
            else if (property.Equals("Rue"))
                Rue = GetIntValue(value);
            else if (property.Equals("IceCrystal_Twinpools_BTN56"))
                IceCrystal_Twinpools_BTN56 = GetIntValue(value);

            else if (property.Equals("BirchLog"))
                BirchLog = GetIntValue(value);
            else if (property.Equals("BirchBranch"))
                BirchBranch = GetIntValue(value);
            else if (property.Equals("BirchSap"))
                BirchSap = GetIntValue(value);
            else if (property.Equals("WaterCrystal_VoorSianSiran_BTN"))
                WaterCrystal_VoorSianSiran_BTN = GetIntValue(value);

            else if (property.Equals("Coneflower"))
                Coneflower = GetIntValue(value);
            else if (property.Equals("FireCrystal_AvaloniaFallen_BTN"))
                FireCrystal_AvaloniaFallen_BTN = GetIntValue(value);

            else if (property.Equals("CamphorwoodBranch"))
                CamphorwoodBranch = GetIntValue(value);
            else if (property.Equals("CamphorwoodLog"))
                CamphorwoodLog = GetIntValue(value);

            else if (property.Equals("Dandelion"))
                Dandelion = GetIntValue(value);
            else if (property.Equals("EarthCrystal_FourArms"))
                EarthCrystal_FourArms = GetIntValue(value);

            else if (property.Equals("CowBitter"))
                CowBitter = GetIntValue(value);
            else if (property.Equals("Gaelicatnip"))
                Gaelicatnip = GetIntValue(value);
            else if (property.Equals("WindCrystal_TheAnsweringQuarter"))
                WindCrystal_TheAnsweringQuarter = GetIntValue(value);

            else if (property.Equals("RainbowCottonBoll"))
                RainbowCottonBoll = GetIntValue(value);
            else if (property.Equals("SprigOfMistDill"))
                SprigOfMistDill = GetIntValue(value);
            else if (property.Equals("IceCrystal_Twinpools_BTN51"))
                IceCrystal_Twinpools_BTN51 = GetIntValue(value);

            else if (property.Equals("DarkChestnut"))
                DarkChestnut = GetIntValue(value);
            else if (property.Equals("DarkChestnutLog"))
                DarkChestnutLog = GetIntValue(value);
            else if (property.Equals("DarkChestnutBranch"))
                DarkChestnutBranch = GetIntValue(value);
            else if (property.Equals("FireCrystal_TheSmolderingWastes_BTN"))
                FireCrystal_TheSmolderingWastes_BTN = GetIntValue(value);

            else if (property.Equals("CyclopsOnion"))
                CyclopsOnion = GetIntValue(value);
            else if (property.Equals("HighlandWheat"))
                HighlandWheat = GetIntValue(value);
            else if (property.Equals("StalkOfRamie"))
                StalkOfRamie = GetIntValue(value);
            else if (property.Equals("FireCrystal_ChocoboForest_BTN"))
                FireCrystal_ChocoboForest_BTN = GetIntValue(value);

            else if (property.Equals("EmeraldBeans"))
                EmeraldBeans = GetIntValue(value);
            else if (property.Equals("MagmaBeet"))
                MagmaBeet = GetIntValue(value);
            else if (property.Equals("EarthCrystal_LandlordColony_BTN"))
                EarthCrystal_LandlordColony_BTN = GetIntValue(value);

            else if (property.Equals("CedarLog"))
                CedarLog = GetIntValue(value);
            else if (property.Equals("CedarBranch"))
                CedarBranch = GetIntValue(value);
            else if (property.Equals("IceCrystal_Riversmeet_BTN"))
                IceCrystal_Riversmeet_BTN = GetIntValue(value);

            else if (property.Equals("BloodCurrants"))
                BloodCurrants = GetIntValue(value);
            else if (property.Equals("WhiteTruffle"))
                WhiteTruffle = GetIntValue(value);
            else if (property.Equals("Aloe"))
                Aloe = GetIntValue(value);
            else if (property.Equals("Flax"))
                Flax = GetIntValue(value);
            else if (property.Equals("HighlandParsley"))
                HighlandParsley = GetIntValue(value);

            else if (property.Equals("FireShard_BTN"))
                FireShard_BTN = GetIntValue(value);
            else if (property.Equals("FireCrystal_BTN"))
                FireCrystal_BTN = GetIntValue(value);
            else if (property.Equals("IceShard_BTN"))
                IceShard_BTN = GetIntValue(value);
            else if (property.Equals("IceCrystal_BTN"))
                IceCrystal_BTN = GetIntValue(value);
            else if (property.Equals("WindShard_BTN"))
                WindShard_BTN = GetIntValue(value);
            else if (property.Equals("WindCrystal_BTN"))
                WindCrystal_BTN = GetIntValue(value);
            else if (property.Equals("EarthShard_BTN"))
                EarthShard_BTN = GetIntValue(value);
            else if (property.Equals("EarthCrystal_BTN"))
                EarthCrystal_BTN = GetIntValue(value);
            else if (property.Equals("LightningShard_BTN"))
                LightningShard_BTN = GetIntValue(value);
            else if (property.Equals("LightningCrystal_BTN"))
                LightningCrystal_BTN = GetIntValue(value);
            else if (property.Equals("WaterShard_BTN"))
                WaterShard_BTN = GetIntValue(value);
            else if (property.Equals("WaterCrystal_BTN"))
                WaterCrystal_BTN = GetIntValue(value);

            else if (property.Equals("CobaltOre"))
                CobaltOre = GetIntValue(value);
            else if (property.Equals("BasiliskEgg"))
                BasiliskEgg = GetIntValue(value);
            else if (property.Equals("ElectrumOre"))
                ElectrumOre = GetIntValue(value);
            else if (property.Equals("MythrilOre"))
                MythrilOre = GetIntValue(value);
            else if (property.Equals("SilverOre"))
                SilverOre = GetIntValue(value);
            else if (property.Equals("EffervescentWater"))
                EffervescentWater = GetIntValue(value);

            else if (property.Equals("FireShard_MIN"))
                FireShard_MIN = GetIntValue(value);
            else if (property.Equals("FireCrystal_MIN"))
                FireCrystal_MIN = GetIntValue(value);
            else if (property.Equals("IceShard_MIN"))
                IceShard_MIN = GetIntValue(value);
            else if (property.Equals("IceCrystal_MIN"))
                IceCrystal_MIN = GetIntValue(value);
            else if (property.Equals("WindShard_MIN"))
                WindShard_MIN = GetIntValue(value);
            else if (property.Equals("WindCrystal_MIN"))
                WindCrystal_MIN = GetIntValue(value);
            else if (property.Equals("EarthShard_MIN"))
                EarthShard_MIN = GetIntValue(value);
            else if (property.Equals("EarthCrystal_MIN"))
                EarthCrystal_MIN = GetIntValue(value);
            else if (property.Equals("LightningShard_MIN"))
                LightningShard_MIN = GetIntValue(value);
            else if (property.Equals("LightningCrystal_MIN"))
                LightningCrystal_MIN = GetIntValue(value);
            else if (property.Equals("WaterShard_MIN"))
                WaterShard_MIN = GetIntValue(value);
            else if (property.Equals("WaterCrystal_MIN"))
                WaterCrystal_MIN = GetIntValue(value);
        }

        private int GetIntValue(string value)
        {
            var x = 0;
            return Int32.TryParse(value, out x) ? x : x;
        }

        private bool GetBooleanValue(string value)
        {
            return value.Equals("1") || value.Equals("True");
        }

        #region INOTIFYPROPERTYCHANGED

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
            if (!propertyName.Equals("IsCheck"))
                IsCheck = false;
        }

        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion INOTIFYPROPERTYCHANGED

        public void SaveChanges()
        {
            if (IsCheck)
                return;

            string text = File.ReadAllText(GlobalDataManager.Instance.FilePath);

            var properties = this.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.Name == "CordialTime_Tangela")
                {
                    int i = 0;
                }
                SavePropertyInFile(ref text, property.Name);
            }
            File.WriteAllText(GlobalDataManager.Instance.FilePath, text);
            IsCheck = true;
        }

        private void SavePropertyInFile(ref string text, string propertyTypeFullName)
        {
            string pattern = "<!ENTITY " + propertyTypeFullName + " \"[^\"]+\">";
            var match = Regex.Match(text, pattern);

            if (!match.Success)
                return;

            if (this.GetType().GetProperty(propertyTypeFullName).PropertyType.Name == "Boolean")
            {
                if (match.Value.Contains("True") || match.Value.Contains("False"))
                {
                    var value = GetStringValueFromBoolean(this.GetType().GetProperty(propertyTypeFullName).GetValue(this));
                    var newText = "<!ENTITY " + propertyTypeFullName + " \"" + value + "\">";
                    text = text.Replace(match.Value, newText);
                    return;
                }
                else
                {
                    var value = GetNumericValueFromBoolean(this.GetType().GetProperty(propertyTypeFullName).GetValue(this));
                    var newText = "<!ENTITY " + propertyTypeFullName + " \"" + value + "\">";
                    text = text.Replace(match.Value, newText);
                    return;
                }
            }
            else
            {
                var value = this.GetType().GetProperty(propertyTypeFullName).GetValue(this);
                var newText = "<!ENTITY " + propertyTypeFullName + " \"" + value + "\">";
                text = text.Replace(match.Value, newText);
                return;
            }
        }

        private object GetStringValueFromBoolean(object getValue)
        {
            var value = (bool)getValue;
            return value ? "True" : "False";
        }

        private int GetNumericValueFromBoolean(object getValue)
        {
            var value = (bool)getValue;
            return value ? 1 : 0;
        }
    }
}
