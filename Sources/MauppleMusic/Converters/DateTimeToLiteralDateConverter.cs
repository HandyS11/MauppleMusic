using System.Globalization;

namespace MauppleMusic.Converters
{
    public class DateTimeToLiteralDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateTime)
            {
                string formattedDate = dateTime.ToString("dd MMMM yyyy", culture);
                return formattedDate;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
