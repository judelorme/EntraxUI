using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using WpfApplication1.Annotations;

namespace WpfApplication1.Model
{
    public class GlobalDataManager: INotifyPropertyChanged
    {
        #region SINGLETON

        private static GlobalDataManager _instance;
        private string _filePath;

        private GlobalDataManager()
        {
        }

        public static GlobalDataManager Instance
        {
            get { return _instance ?? (_instance = new GlobalDataManager()); }
        }

        #endregion SINGLETON

        public string FilePath
        {
            get { return _filePath; }
            set
            {
                if (value == _filePath) return;
                _filePath = value;
                OnPropertyChanged();
            }
        }

        public CultureInfo PreviousCurrentCulture { get; set; }
        public CultureInfo PreviousCurrentUICulture { get; set; }
        public CultureInfo CurrentCulture { get; set; }
        public CultureInfo CurrentUICulture { get; set; }

        public bool IsOpeningFileBrowser { get; set; }
        public int CurrentOpenTab { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
