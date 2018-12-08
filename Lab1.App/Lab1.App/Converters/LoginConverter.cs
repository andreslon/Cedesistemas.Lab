using System;
using System.Globalization;
using Xamarin.Forms;

namespace Lab1.App.Converters
{
    public class LoginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var data = value.ToString();

                if (data.Length <= 3)
                {
                    return Color.Red;
                }
                else if (data.Length > 3 && data.Length <= 6)
                {
                    return Color.Orange;
                }
                else
                {
                    return Color.Green;
                }
            }
            return Color.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
