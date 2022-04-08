using System;
using System.Globalization;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ColorToInverseColorConverter
{
    /// <summary>
    /// This class converts Color to its InverseColor and viceversa
    /// </summary>
    public class ColorToInverseColorConverter : IValueConverter
    {
        /// <summary>
        /// This method convert the Color to its InverseColor
        /// </summary>
        /// <param name="value"> value must be the type of Color </param>
        /// <param name="targetType"> The type of the target property </param>
        /// <param name="parameter"> Additonal parameter for converter to handle, Not used </param>
        /// <param name="culture"> Instance of CultureInfo, Not used </param>
        /// <returns>InverseColor</returns>
        /// <exception cref="ArgumentException">Exception thrown when the value type is null or not a type of Color</exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ConvertColorToInverseColor(value);
        }

        /// <summary>
        /// This method convert Back the InverseColor value to its Color value
        /// </summary>
        /// <param name="value"> value be the type of InverseColor </param>
        /// <param name="targetType"> The type of the target property</param>
        /// <param name="parameter"> Additonal parameter for converter to handle, Not used</param>
        /// <param name="culture"> Instance of CultureInfo, Not used </param>
        /// <returns>Color</returns>
        /// <exception cref="ArgumentException">Exception thrown when the value type is null or not a type of InverseColor</exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ConvertColorToInverseColor(value);
        }
        
        /// <summary>
        /// This method convert Color to its Inverse Color
        /// </summary>
        /// <param name="value">value to be the type of Color</param>
        /// <returns>Inversed color of given color</returns>
        /// <exception cref="ArgumentException">Exception thrown when value is null or other than color type</exception>
        private Color ConvertColorToInverseColor(object value)
        {
            if (value != null && value is Color color)
            {
                return new Color(1 - color.Red, 1 - color.Green, 1 - color.Blue);
            }
            throw new ArgumentException("Expected value to be a type of Color", nameof(value));
        }
    }
}
