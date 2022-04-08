using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace EnumToIntConverter
{
    /// <summary>
    /// This class is used to convert value from enum to int
    /// </summary>
    public class EnumToIntConverter : IValueConverter
    {

        #region methods
        /// <summary>
        /// This method is used to convert enum to int
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value is Enum)
                {
                    return System.Convert.ToInt32(value);
                }
                throw new ArgumentException($"Value is not of enum type, it is of {nameof(value)}");
            }

            return null;

        }

        /// <summary>
        /// This method is used to check if value is int and return int value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value is int enumNumber && Enum.IsDefined(targetType, enumNumber))
                {
                    return Enum.ToObject(targetType, enumNumber);
                }
                throw new ArgumentException($"Value is not of enummeration type");
            }
            throw new ArgumentException($"Value is null");
        }
        #endregion
    }
}
