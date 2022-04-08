using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace FormatStringConverter
{

    /// <summary>
    /// This Converter Formats the Input string to the desired format.
    /// </summary>
    public class FormatStringConverter : IValueConverter
    {

        /// <summary>
        /// This method Converts the <see cref="IFormattable"/> To the Desired Format <see cref="string"/>.
        /// </summary>
        /// <param name="value">The Input data Passed to the Target</param>
        /// <param name="targetType">Type of the Target Property</param>
        /// <param name="parameter">The Desired Format </param>
        /// <param name="culture">Provides Information about a specific culture</param>
        /// <returns>Returns the Formatted string</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value == null)
            {
                throw new ArgumentException("Value is Null");
            }
            else
            {
                var stringFormat = parameter as string;
                var formattableString = value as IFormattable;
                if (formattableString == null || stringFormat == null)
                    throw new ArgumentException("value is not of type Iformattable or Format is null", nameof(value));
                else
                    return formattableString.ToString(stringFormat, null);
            }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <param name="value">The Input data Passed to the Target</param>
        /// <param name="targetType">Type of the Target Property</param>
        /// <param name="parameter">The Desired Format </param>
        /// <param name="culture">Provides Information about a specific culture</param>
        /// <returns>Not implemented</returns>
        /// <exception cref="NotImplementedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


}
