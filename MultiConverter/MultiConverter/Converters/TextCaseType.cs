using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiConverter.Converters
{
	public enum TextCaseType
	{
		/// <summary>Should not be converted</summary>
		None,

		/// <summary>Convert to uppercase</summary>
		Upper,

		/// <summary>Convert to lowercase</summary>
		Lower,

		/// <summary>Converts the first letter to upper only</summary>
		FirstUpperRestLower,
	}
}
