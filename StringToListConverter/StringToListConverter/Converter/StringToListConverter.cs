using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToListConverter
{
    /// <summary>
    /// This class is used to convert string to list
    /// </summary>
    public class StringToListConverter : IValueConverter
    {
        #region fields
        public string Separator { get; set; } = string.Empty;

        public IList<string> Separators { get; } = new List<string>();

        public StringSplitOptions SplitOptions { get; set; } = StringSplitOptions.None;
        #endregion

        #region methods
        /// <summary>
        /// This method is used to convert string to list
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
                if(value is string stringValue)
                {
                    if (Separators.Count == 0 )
                    {
                        string[] substrings = stringValue.Split(Separator, SplitOptions);
                        List<string> listString = substrings.ToList<string>();
                        return listString;
                    }
                    else if (Separators.Count >= 1)
                    {
                        string[] substrings = stringValue.Split(Separators.ToArray(), SplitOptions);
                        List<string> listString = substrings.ToList<string>();
                        return listString;
                    }
                    else
                    {
                        return string.Empty;
                    }
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
