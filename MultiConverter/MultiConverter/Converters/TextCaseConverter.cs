using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiConverter.Converters
{
	public class TextCaseConverter : IValueConverter
	{
	
		public TextCaseType Type { get; set; }

	
		public object? Convert(object? value, Type? targetType, object? parameter, CultureInfo? culture)
		{
			var str = value?.ToString();
			if (str == null || string.IsNullOrWhiteSpace(str))
				return str;

			return GetParameter(parameter) switch
			{
				TextCaseType.Lower => str.ToLowerInvariant(),
				TextCaseType.Upper => str.ToUpperInvariant(),
				TextCaseType.FirstUpperRestLower => str.Substring(0, 1).ToUpperInvariant() + str.ToString().Substring(1).ToLowerInvariant(),
				_ => str
			};
		}

		
		public object ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo? culture)
			=> throw new NotImplementedException();

		TextCaseType GetParameter(object? parameter) => parameter switch
		{
			TextCaseType type => type,
			string typeString => Enum.TryParse(typeString, out TextCaseType result)
				? result
				: throw new ArgumentException("Cannot parse text case from the string", nameof(parameter)),
			int typeInt => Enum.IsDefined(typeof(TextCaseType), typeInt)
				? (TextCaseType)typeInt
				: throw new ArgumentException("Cannot convert integer to text case enum value", nameof(parameter)),
			_ => Type,
		};
	}
}
