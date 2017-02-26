using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApplication1.Model;

namespace WpfApplication1.Snorlax_Models
{
    public enum Job
    {
        Miner,
        Botanist
    }

    public class GatherableItem
    {

        public string Name { get; set; }

        private Job _job;
        private int _quantity;
        private bool _asCollectable;
        private string _propertyName;

        public Job Job
        {
            get { return _job; }
            set
            {
                _job = value;
                switch (Job)
                {
                    case Job.Miner:
                        BackgroundColor = new SolidColorBrush(Colors.SandyBrown);
                        break;
                    case Job.Botanist:
                        BackgroundColor = new SolidColorBrush(Colors.LightGreen);
                        break;
                }
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                if (PropertyName != null && _quantity != 0 && (int)EntraxModel.Instance.GetType().GetProperty(this.PropertyName).GetValue(EntraxModel.Instance) != _quantity)
                {
                    EntraxModel.Instance.GetType().GetProperty(this.PropertyName).SetValue(EntraxModel.Instance, _quantity);
                }
            }
        }

        public bool IsCollectable { get; set; }

        public bool AsCollectable
        {
            get { return _asCollectable; }
            set
            {
                _asCollectable = value;
                if (CollectablePropertyName != null)
                {
                    EntraxModel.Instance.GetType().GetProperty(this.CollectablePropertyName).SetValue(EntraxModel.Instance, _asCollectable);
                }
            }
        }

        public string Localisation { get; set; }
        public SolidColorBrush BackgroundColor { get; set; }
        public int FirstStartTime { get; set; }
        public int SecondStartTime { get; set; }
        public bool HasSecondStartTime { get; set; }

        public string PropertyName
        {
            get { return _propertyName; }
            set
            {
                _propertyName = value;
                Name = Properties.Resources.ResourceManager.GetString(_propertyName);
                ImagePath = new BitmapImage(new Uri("/Assets/Items/" + _propertyName + ".jpg", UriKind.Relative));
            }
        }

        public BitmapImage ImagePath { get; set; }

        public string CollectablePropertyName { get; set; }

        public string GetTime
        {
            get
            {
                if (HasSecondStartTime)
                    return FirstStartTime + "h / " + SecondStartTime + "h";
                return FirstStartTime + "h";
            }
        }
    }
}
