using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToStringConverter
{
    /// <summary>
    /// This class is used to convert list to string
    /// </summary>
    public class ListToStringConverter :IValueConverter
    {
        #region fields
        public string Separator { get; set; } = string.Empty;

        #endregion

        #region methods
        /// <summary>
        /// This method is used to convert list to string
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
                if (value is ICollection listOfValues)
                {
                    var listElement = from val in listOfValues.OfType<object>()
                                      select val.ToString();

                    return string.Join(Separator, listElement);
                }
                throw new ArgumentException($"Value is of {value.GetType}");

            }
            else
            {
                return string.Empty;
            }
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
