using System;
using System.Globalization;
using Xamarin.Forms;

namespace Datarynx.ValueConverter
{
    public class TextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isSelected = (bool)value;
            if (!isSelected)
            {
                return "5";
            }
            else
            {
                return "1";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
