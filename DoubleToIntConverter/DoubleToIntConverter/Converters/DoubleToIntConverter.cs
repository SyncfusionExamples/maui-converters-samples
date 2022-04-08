using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DoubleToIntConverter.Converters
{
    public class DoubleToIntConverter : IValueConverter
    { 
        /// <summary>
        /// Convert method used to get the Double value and converts it into the int value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {         
            if (value != null && value is double)
                return System.Convert.ToInt32(value);
            throw new ArgumentNullException("Value should not be null");
            
        }
        /// <summary>
        /// Convert method used to get the int value and converts it into the double value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is int)
                return System.Convert.ToDouble(value);
            throw new ArgumentNullException("Value should not be null");
        }

    }
}
