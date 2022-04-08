using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiConverter.Converters
{
	public class EqualConverter : IValueConverter
	{
	
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => ConvertInternal(value, parameter);

		internal static bool ConvertInternal(object? value, object? parameter) =>
			(value != null && value.Equals(parameter)) || (value == null && parameter == null);

		
		public object ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo? culture)
			=> throw new NotImplementedException();

      
    }
}
