using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericToBoolConverter.Converters
{
    public class NumericToBoolConverter : IValueConverter
    {
        /// <summary>
        /// Convert method is used to convert numeric to bool value. It changes 0 into false and 1 into true.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {    
            return value != null
                ? System.Convert.ToBoolean(value)
                : throw new ArgumentNullException("Value should not be null" + nameof(value));  
        }

        /// <summary>
        ///Convert back method is used to convert bool to numeric value. It changes false into 0 and true into 1.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null
                ? !(bool)value ? 0:1
                : throw new ArgumentNullException("Value should not be null" + nameof(value));

        }
     
      
    }
}



