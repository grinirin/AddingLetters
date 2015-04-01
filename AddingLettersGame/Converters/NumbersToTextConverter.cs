using System;
using Windows.UI.Xaml.Data;

namespace AddingLettersGame.Converters
{
    public class NumbersToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is int)) return string.Empty;

            var number = (int)value;

            return number == 0 ? string.Empty : number.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
