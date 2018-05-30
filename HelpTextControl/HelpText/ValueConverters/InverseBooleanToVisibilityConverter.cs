using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace HelpTextControl.HelpText.ValueConverters
{
    public class InverseBooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is bool && System.Convert.ToBoolean(value)) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is Visibility && (Visibility)value != Visibility.Visible);
        }
    }
}
