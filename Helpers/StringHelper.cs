using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers;

public static class StringExtentionHelper
{
	public static string[] SplitAtNewLine(this string input)
	{
		char[] _splitSeparator = new[] { '\n' };

		return input.Split(_splitSeparator, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
	}
}


