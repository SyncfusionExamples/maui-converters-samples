using System;
using System.Globalization;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ColorToGrayScaleColorConverter;

/// <summary>
/// This class converts the Color to GrayScaleColor.
/// </summary>
public class ColorToGrayScaleColorConverter : IValueConverter
{
    /// <summary>
    /// This method convert the Color to its GrayScaleColor
    /// </summary>
    /// <param name="value"> value must be the type of Color </param>
    /// <param name="targetType"> The type of the target property </param>
    /// <param name="parameter"> Additonal parameter for converter to handle, Not used </param>
    /// <param name="culture"> Instance of CultureInfo, Not used </param>
    /// <returns>GrayScaleColor</returns>
    /// <exception cref="ArgumentException">Exception thrown when the value type is null or not a type of Color</exception>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null && value is Color color)
        {
            return GetGrayScaleColor(color);
        }
        throw new ArgumentException("Expected value to be a type of Color", nameof(value));
    }

    /// <summary>
    /// Convert Back is not supported for ColorToGrayScaleColor Converter
    /// </summary>
    /// <exception cref="NotSupportedException"></exception>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException("ConvertBack to original value is not possible. BindingMode must be set as OneWay."); ;
    }

    #region Private Method
    /// <summary>
    /// This method perform the conversion opertion of Color value to GrayScale Color value
    /// </summary>
    /// <param name="color">Color</param>
    /// <returns>The GrayScale Color value of the given Color</returns>
    private Color GetGrayScaleColor(Color color)
    {
        float grayValue = (color.Red + color.Green + color.Blue)/3;
        return new Color(grayValue);
    }
    #endregion
}

