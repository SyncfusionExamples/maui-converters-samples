using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolToObjectConverter.Converters
{

    /// <summary>
    /// This class Converts Bool value into object and vice versa.
    /// </summary>
    public class BoolToObjectConverter : IValueConverter
    {

        #region Property

        /// <summary>
        /// Object assigned for the True value.
        /// </summary>
        public object? TrueValueObject { get; set; }

        /// <summary>
        /// Object assigned for the False value.
        /// </summary>
        public object? FalseValueObject { get; set; }

        #endregion

        #region method

        /// <summary>
        /// Converts Boolean to object
        /// </summary>
        /// <param name="value">the value to be converted</param>
        /// <param name="targetType">Type of the Target value </param>
        /// <param name="parameter">Additional parameter For the conversion</param>
        /// <param name="culture">culture to use in the converter</param>
        /// <returns>Returns TrueObject if value equals True, otherwise returns FalseObject/></returns>
        /// <exception cref="ArgumentException"></exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value != null)
            {
                if (value is bool outputValue)
                {
                    return outputValue ? TrueValueObject! : FalseValueObject!;
                }
                throw new ArgumentException($"Value is not a boolean Type", nameof(value));
            }
            throw new ArgumentException($"Value is null", nameof(value));
        }

        /// <summary>
        /// Converts object to Boolean
        /// </summary>
        /// <param name="value">the value to be converted</param>
        /// <param name="targetType">Type of the Target value </param>
        /// <param name="parameter">Additional parameter For the conversion</param>
        /// <param name="culture">culture to use in the converter</param>
        /// <returns>Returns True for True Object and False for False Object</returns>
        /// <exception cref="ArgumentException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.Equals(TrueValueObject))
                    return true;
                else if (value.Equals(FalseValueObject))
                    return false;
            }

            throw new ArgumentException($"Value is null", nameof(value));

        }

        #endregion
    }
}
