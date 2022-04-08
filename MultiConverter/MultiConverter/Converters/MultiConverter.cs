using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiConverter.Converters
{
	public class MultiConverter : List<IValueConverter>, IValueConverter
	{
		/// <summary>
		///  Uses the incoming converters to convert the value based on the converter type and value.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
			if (value == null)
				throw new ArgumentNullException("value");
			if (parameter is IList<MultiConverterParameter> propertiesOfConverter)
			{
				return this.Aggregate(value, (currentValue, currentConverter) => currentConverter.Convert(currentValue, targetType,
						 propertiesOfConverter.FirstOrDefault(x => x.TypeOfConverter == currentConverter.GetType())?.ValueOfConverter, culture));
			}
			else
            {
				return this.Aggregate(value, (currentValue, currentConverter) => currentConverter.Convert(currentValue, targetType, parameter, culture));
			}
	    }
		/// <summary>
		/// This method is not implemented.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
			=> throw new NotImplementedException();
	}
}
 