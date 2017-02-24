using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfApplication1.Convertor
{
    public sealed class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var res = (value is bool && (bool)value) ? Visibility.Visible : Visibility.Collapsed;
            return res;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is Visibility && (Visibility)value == Visibility.Visible;
        }
    }
}
