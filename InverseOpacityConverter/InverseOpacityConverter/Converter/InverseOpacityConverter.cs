using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverseOpacityConverter
{
    /// <summary>
    /// This class is used to convert opacity value to inverse opacity value
    /// </summary>
    public class InverseOpacityConverter : IValueConverter
    {
        #region methods
        /// <summary>
        /// This method is convert opcatity value to inverse opacity value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null)
            {
                double opacityValue = System.Convert.ToDouble(value);

                double inverseOpacityValue = 1 - opacityValue;

                if (opacityValue >= 0 && opacityValue <= 1)
                {
                    return Math.Round(inverseOpacityValue, 1);
                }
                else if (opacityValue < 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return null;
            }
            
        }

        /// <summary>
        /// This method is used to convert inverse opacity value to opacity value
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
                double inverseOpacityValue = System.Convert.ToDouble(value);

                double opacityValue = 1 - inverseOpacityValue;

                if (inverseOpacityValue >= 0 && inverseOpacityValue <= 1)
                {
                    return Math.Round(opacityValue, 1);
                }
                else if (inverseOpacityValue < 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
