using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IsListNotNullOrEmptyConverter.Converters
{
    /// <summary>
    /// Converts the incoming value into bool whether the list is not null and empty
    /// </summary>
    public class IsListNotNullOrEmpty : IValueConverter
    {
        /// <summary>
        /// Converts the incoming value into bool whether the list is not null and empty
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="targetType">This is not implemented</param>
        /// <param name="parameter">This is not implemented</param>
        /// <param name="culture">This is not implemented</param>
        /// <returns>Returns the bool value which indicates the list is not null and empty</returns>
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return false;
            }
            else if (value is not ICollection)
            {
                throw new ArgumentException("Value cannot be casted to ICollection", nameof(value));
            }
            else
            {
                var collection = (ICollection)value;
                return collection.Count != 0;
            }

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
