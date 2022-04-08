using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCaseConverter.Converters
{
    /// <summary>
    /// This Converter class converts the Input text to the Text with Required Casing.
    /// </summary>
    public class TextCaseConverter : IValueConverter
    {
        #region Property
        /// <summary>
        /// Get and Sets the Required text case using the CasingMode Enum class. 
        /// </summary>
        public CasingMode CasingMode { get; set; }

        #endregion

        #region methods

        /// <summary>
        /// This Method Converts the Input Text to the Required Text Case.
        /// </summary>
        /// <param name="value">The text to be converted</param>
        /// <param name="targetType">The type of the binding target.</param>
        /// <param name="parameter">The Desired Format</param>
        /// <param name="culture">Provides Information about a specific culture</param>
        /// <returns>Returns the required Format of the Text.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                throw new ArgumentException("Value is Null");

            if (value is string inputString)
                return this.GetCase(inputString, CasingMode);

            throw new ArgumentException("Input value  is not of Type String ", nameof(value));

        }

        /// <summary>
        /// Method Returns the Desired Case of the Input string.
        /// </summary>
        /// <param name="Inputstring">The Input string to convert</param>
        /// <param name="CasingMode">Selected TextCaseType enum value</param>
        /// <returns>Returns the Desired Case of the Input string.</returns>
        private string GetCase(string Inputstring, CasingMode CasingMode)
        {
            switch (CasingMode)
            {
                case CasingMode.LowerCase:
                    return Inputstring.ToLowerInvariant();
                case CasingMode.UpperCase:
                    return Inputstring.ToUpperInvariant();
                case CasingMode.ParagraphCase:
                    return Inputstring.Substring(0, 1).ToUpperInvariant() + Inputstring.ToString().Substring(1).ToLowerInvariant();
                case CasingMode.PascalCase:
                    string outputString = string.Join("", Inputstring.Select(inputChar =>
                    char.IsWhiteSpace(inputChar) & char.IsLetterOrDigit(inputChar) ? inputChar.ToString().ToLower() : inputChar.ToString()).ToArray());
                    var stringArray = (outputString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(splitedString =>
                       $"{splitedString.Substring(0, 1).ToUpper()}{splitedString.Substring(1)}"));
                    outputString = string.Join("", stringArray);
                    return outputString;

                default:
                    return Inputstring;
            }

        }

        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <param name="value">The text to be converted</param>
        /// <param name="targetType">The type of the binding target.</param>
        /// <param name="parameter">The Desired Format</param>
        /// <param name="culture">Provides Information about a specific culture</param>
        /// <returns>Not Implemented</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    /// <summary>
    /// Enum class for the selecting the Text Case type
    /// </summary>
    public enum CasingMode
    {

        /// <summary>
        /// Convert to uppercase
        /// </summary>
        UpperCase,

        /// <summary>
        /// Convert to lowercase
        /// </summary>
        LowerCase,

        /// <summary>
        /// Converts the first letter of the paragraph to upper
        /// </summary>
        ParagraphCase,

        /// <summary>
        /// Converts the Pascal case
        /// </summary>
        PascalCase,
    }
}
