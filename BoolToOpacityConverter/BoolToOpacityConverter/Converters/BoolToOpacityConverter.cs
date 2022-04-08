using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolToOpacityConverter.Converters
{
    public class BoolToOpacityConverter : IValueConverter
    {
        /// <summary>
        /// Convert method is used to convert the boolean value to opacity. 
        /// If the boolean value is true it converts into 1 and if it is false it converts into false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value!=null
                ?(bool)value ? 1 : 0
                : throw new ArgumentNullException("Value should not be null"+nameof(value));
        }
        /// <summary>
        /// Convert Back method is used to convert the opacity value to boolean. 
        /// If the opacity value is 1 it converts into true and if it is false it converts into 1.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value!=null
                ?(double)value == 1 ? true : false
                :throw new ArgumentNullException("Value should not be null" + nameof(value));

        }
    }
}
