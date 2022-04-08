using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IndexToArrayItemConverter.Converters
{
    /// <summary>
    /// Converts the incoming index value and finds the array value corresponding to the index value and vice versa
    /// </summary>
    internal class IndexToArrayItemConverter : IValueConverter
    {
        /// <summary>
        /// Converts an index to array item
        /// </summary>
        /// <param name="value">The index of an array, This value can either int or double</param>
        /// <param name="targetType">This is not implemented</param>
        /// <param name="parameter">Array items</param>
        /// <param name="culture">This is not implemented</param>
        /// <returns>Returns the array item corresponds to the index</returns>

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                throw new ArgumentNullException("Value should not null",nameof(value));

            if (parameter == null)
                throw new ArgumentNullException("Parameter should not null", nameof(parameter));

            if (value is not int indexValue)
            {
                if (value is not double)
                {
                    throw new ArgumentException("Value is not a valid integer", nameof(value));
                }
                indexValue = System.Convert.ToInt32(value);
            }

            if (parameter is not ICollection<object> collection)
                throw new ArgumentException("Parameter is not a valid array", nameof(parameter));

            var list = collection.ToList();

            if (indexValue < 0 || indexValue >= list.Count)
                throw new ArgumentOutOfRangeException("Index was out of range",nameof(value));

            return list[indexValue];
        }
        /// <summary>
        /// Converts an array item to the corresponding index value
        /// </summary>
        /// <param name="value">Selected value in the array item</param>
        /// <param name="targetType">This is not implemented</param>
        /// <param name="parameter">Array Item</param>
        /// <param name="culture">This is not implemented</param>
        /// <returns>The index of the selected array item</returns>
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                throw new ArgumentNullException("Value should not be null",nameof (value));

            if (parameter == null)
                throw new ArgumentNullException("Parameter should not null", nameof(value));

            if (parameter is not ICollection<object> collection)
                throw new ArgumentException("Parameter is not a valid array", nameof(parameter));

            var list = collection.ToList();
            if(list.Contains(value))
                return list.IndexOf(value);

            throw new ArgumentException("Value does not exist in the array", nameof(value));
        }
    }
}
