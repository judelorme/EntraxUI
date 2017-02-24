using System.ComponentModel;
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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
