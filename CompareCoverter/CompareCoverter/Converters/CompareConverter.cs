using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCoverter.Converters
{
	/// <summary>
	/// Based on the Comparison result, returns either true object or false object or boolean
	/// </summary>
    internal class CompareConverter:IMarkupExtension<IValueConverter>,IValueConverter
    {
		/// <summary>
		/// Comparison operator
		/// </summary>
		public enum OperatorType
		{
			/// <summary>
			/// Not Equal Operator
			/// </summary>
			NotEqual,

			/// <summary>
			/// Smaller Operator
			/// </summary>
			Smaller,

			/// <summary>
			/// Smaller or Equal Operator
			/// </summary>
			SmallerOrEqual,

			/// <summary>
			/// Equal Operator
			/// </summary>
			Equal,

			/// <summary>
			/// Greater Operator
			/// </summary>
			Greater,

			/// <summary>
			/// Greater or Equal Operator
			/// </summary>
			GreaterOrEqual,
		}

		/// <summary>
		/// The comparing value.
		/// </summary>
		public IComparable ValueForComparing { get; set; }

		/// <summary>
		/// The comparison operator.
		/// </summary>
		public OperatorType ComparisonOperator { get; set; }

		/// <summary>
		/// The object that corresponds to True value.
		/// </summary>
		public object TrueObject { get; set; }

		/// <summary>
		/// The object that corresponds to False value.
		/// </summary>
		public object FalseObject { get; set; }
		enum ModeOptions
		{
			Boolean,
			Object
		}

		ModeOptions modeOption;

		/// <summary>
		/// Converts an object that implements IComparable to a specified object or a boolean based on a comparison result.
		/// </summary>
		/// <param name="value">The value to convert</param>
		/// <param name="targetType">This is not implemented.</param>
		/// <param name="parameter">This is not implemented.</param>
		/// <param name="culture">This is not implemented.</param>
		/// <returns>True object or False object or boolean value based on the comparison result</returns>

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if(ValueForComparing == null)
            {
				throw new ArgumentNullException("Comparing Value should not be null",nameof(ValueForComparing));
            }
			if (value is not IComparable)
			{
				throw new ArgumentException("is expected to implement IComparable interface.", nameof(value));
			}
			if (TrueObject != null)
			{
				modeOption = ModeOptions.Object;
			}

			var valueIComparable = (IComparable)value;
			var result = valueIComparable.CompareTo(ValueForComparing);
			object resultMode = null;
			switch (ComparisonOperator)
            {
                case OperatorType.Smaller:
                    resultMode = CheckCondition(result < 0);
                    break;
                case OperatorType.SmallerOrEqual:
					resultMode = CheckCondition(result <= 0);
                    break;
                case OperatorType.Equal:
                    resultMode = CheckCondition(result == 0);
                    break;
                case OperatorType.NotEqual:
                    resultMode = CheckCondition(result != 0);
                    break;
                case OperatorType.GreaterOrEqual:
                    resultMode = CheckCondition(result >= 0);
                    break;
                case OperatorType.Greater:
                    resultMode = CheckCondition(result > 0);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Comparison Operator is not suppoerted");
            }
			return resultMode;
        }

		object CheckCondition(bool comparisonResult)
		{
			if (modeOption == ModeOptions.Object)
				return comparisonResult ? TrueObject! : FalseObject!;
			
			return comparisonResult;
		}

		/// <summary>
		/// Convert back method not supported because it is impossible to revert to original value
		/// </summary>
		/// <exception cref="NotSupportedException"></exception>
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
			throw new NotSupportedException("Impossible to revert to original value. Consider setting BindingMode to OneWay.");
		}

        public IValueConverter ProvideValue(IServiceProvider serviceProvider)
        {
			return (IValueConverter)this;
		}
        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
			return ((IMarkupExtension<IValueConverter>)this).ProvideValue(serviceProvider);
		}
        
    }
}
