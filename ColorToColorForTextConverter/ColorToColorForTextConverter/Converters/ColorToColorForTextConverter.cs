using System;
using System.Globalization;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ColorToColorForTextConverter
{
    /// <summary>
    /// This class converts Color To ColorForText
    /// </summary>
    public class ColorToColorForTextConverter : IValueConverter
    {
        /// <summary>
        /// This method convert TextColor as respective to BackgroundColor 
        /// </summary>
        /// <param name="value">value must be the type of Color</param>
        /// <param name="targetType">The type of target property</param>
        /// <param name="parameter">Additonal parameter for converter to handle, Not used</param>
        /// <param name="culture">Instance of CultureInfo, Not used</param>
        /// <returns>TextColor</returns>
        /// <exception cref="ArgumentException">Exception thrown when the value type is null or not a type of Color</exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is Color color)
            {
                return GetColorForText(color);
            }
            throw new ArgumentException("Expected value to be a type of Color", nameof(value));
        }

        /// <summary>
        /// Convert Back is not supported for ColorToColorForText Converter
        /// </summary>
        /// <exception cref="NotSupportedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("ConvertBack to original value is not possible. BindingMode must be set as OneWay."); ;
        }

        #region Private Methods
        /// <summary>
        /// This method return the TextColor suitable for its BackgroundColor based on its Luma value
        /// </summary>
        /// <param name="color">Color</param>
        /// <returns>If background is light color, it returns black text color else it returns white text color</returns>
        private Color GetColorForText(Color color)
        {
            return color.GetLuminosity() > 0.72 ? Colors.Black : Colors.White;
        }
        #endregion

    }
}
