using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalValueConverter.Converters
{
    /// <summary>
    /// This Converter converts the Input decimal value to the Decimal value with desired decimal places.
    /// </summary>
    public class DecimalValueConverter : IValueConverter
    {
        /// <summary>
        /// Gets and Sets the Decimal Places from the users.
        /// </summary>
        public int DecimalPlaceLimit { get; set; }

        /// <summary>
        /// Gets and Sets the Output format from the users.
        /// </summary>
        public OutputType OutputType { get; set; }

        /// <summary>
        /// Converts the input value with required Decimal places.
        /// </summary>
        /// <param name="value">The Input data Passed to the Target</param>
        /// <param name="targetType">Type of the Target Property</param>
        /// <param name="parameter">The Desired Format </param>
        /// <param name="culture">Provides Information about a specific culture</param>
        /// <returns>Returns the Formatted string</returns>
        /// <exception cref="ArgumentException"></exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string outputZeroString = "0";
            if (value != null)
            {
                if (value.ToString() == "")
                {
                    outputZeroString = new string('0', DecimalPlaceLimit);
                    return $"0.{outputZeroString}";
                }

                decimal decimalValue = decimal.Parse(value.ToString()!);
                switch (OutputType)
                {
                    case OutputType.String:

                        if (decimalValue % 1 == 0)
                        {
                            outputZeroString = new string('0', DecimalPlaceLimit);
                            return $"{Math.Round(decimalValue)}.{outputZeroString}";
                        }

                        else
                        {
                            string decimalString = decimalValue.ToString();
                            int length = decimalString.Substring(decimalString.IndexOf(".")).Length;

                            if ((length - 1) >= 1 && ((length - 1) <= DecimalPlaceLimit))
                            {
                                outputZeroString = new string('0', DecimalPlaceLimit - (length - 1));

                                return $"{decimalValue}{outputZeroString}";
                            }
                            return Math.Round(decimalValue, DecimalPlaceLimit).ToString();
                        }

                    case OutputType.Decimal:
                    default:
                        return Math.Round(decimalValue, DecimalPlaceLimit);
                }
            }

            else
            {
                throw new ArgumentException("Value cannot be null", nameof(value));
            }
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <param name="value">The Input data Passed to the Target</param>
        /// <param name="targetType">Type of the Target Property</param>
        /// <param name="parameter">The Desired Format </param>
        /// <param name="culture">Provides Information about a specific culture</param>
        /// <returns>Not Implemented</returns>
        /// <exception cref="NotImplementedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Enum for the Showing output in the required format.
    /// </summary>
    public enum OutputType
    {
        /// <summary>
        /// Returns output as String
        /// </summary>
        String,

        /// <summary>
        /// Returns output as decimal
        /// </summary>
        Decimal,

    }

}
