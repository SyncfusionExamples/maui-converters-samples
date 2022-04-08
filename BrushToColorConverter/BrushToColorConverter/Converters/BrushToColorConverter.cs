using System;
using System.Globalization;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace BrushToColorConverter
{
    /// <summary>
    /// This class converts Brush to Color and Color to Brush
    /// </summary>
    public class BrushToColorConverter : IValueConverter
    {
        /// <summary>
        /// This method converts Brush into Color
        /// </summary>
        /// <param name="value">value must be the type of SolidColorBrush</param>
        /// <param name="targetType">The type of the target property </param>
        /// <param name="parameter">Additonal parameter for converter to handle, Not used</param>
        /// <param name="culture">Instance of CultureInfo, Not used</param>
        /// <returns>Color</returns>
        /// <exception cref="ArgumentException">Exception thrown when the value type is null or not a type of Brush</exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!Brush.IsNullOrEmpty(value as SolidColorBrush))
            {
                SolidColorBrush brush = (SolidColorBrush)value;
                return brush.Color;
            }
            throw new ArgumentException("Expected value to be a type of Brush", nameof(value));
        }

        /// <summary>
        /// This method converts Color into Brush
        /// </summary>
        /// <param name="value">value must be the type of color</param>
        /// <param name="targetType">The type of the target property</param>
        /// <param name="parameter">Additonal parameter for converter to handle, Not used</param>
        /// <param name="culture">Instance of CultureInfo, Not used</param>
        /// <returns>SolidColorBrush</returns>
        /// <exception cref="ArgumentException">Exception thrown when the value type is null or not a type of Color</exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is Color color)
            {
                return new SolidColorBrush(color);
            }
            throw new ArgumentException("Expected value to be a type of Color", nameof(value));
        }
    }
}
