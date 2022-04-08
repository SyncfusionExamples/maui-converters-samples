using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualConverter
{
    /// <summary>
    /// This class is used to compare the value and parameter 
    /// and check whether it's equal or not
    /// </summary>
    public class EqualConverter : IValueConverter
    {
        #region methods
        /// <summary>
        /// This method is used to compare the value and parameter
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool checkEqual = ((value != null && value.Equals(parameter)) || (value == null && parameter == null));

            return checkEqual;
        }

        /// <summary>
        /// This method is not implemented and will throw a <see cref="NotImplementedException"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
