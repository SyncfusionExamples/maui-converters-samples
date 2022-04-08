using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsStringNotNullOrWhiteSpaceConverter.Converters
{
    /// <summary>
    /// Converts the incoming value into bool whether the value string is not null and white space
    /// </summary>
    internal class IsStringNotNullOrWhiteSpace : IValueConverter
    {
        /// <summary>
        /// Converts the incoming value into bool whether the incoming value is not null and white space
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="targetType">This is not implemented</param>
        /// <param name="parameter">This is not implemented</param>
        /// <param name="culture">This is not implemented</param>
        /// <returns>Returns a bool value which indicates whether the incoming value is not null and white space</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(value as string))
                return false;
            return true;
        }

        /// <summary>
        /// Convert back method not supported because it is impossible to revert to original value
        /// </summary>
        /// <exception cref="NotSupportedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Impossible to revert to original value. Consider setting BindingMode to OneWay.");
        }
    }
}
