namespace Solutions;

internal class Digit
{
	public int Value { get; set; }
	public int Index { get; set; }

}
public static class Day1
{
	private static readonly char[] _splitSeparator = new[] { '\n' };
	private static readonly Dictionary<int, string> _searchValues = new()
	{
		{ 1, "one" },
		{ 2, "two" },
		{ 3, "three" },
		{ 4, "four" },
		{ 5, "five" },
		{ 6, "six" },
		{ 7, "seven" },
		{ 8, "eight" },
		{ 9, "nine" },
	};
	public static int Solve(string input)
	{
		int result = 0;
		foreach (string line in input.Split(_splitSeparator, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
		{
			List<Digit> lineDigits = new();
			FindDigitsAsWords(line, lineDigits);
			FindDigitsAsNumers(line, lineDigits);

			if (lineDigits.Count > 0)
			{
				CreateNumberForLine(ref result, lineDigits);
			}
		}
		return result;
	}

	private static void CreateNumberForLine(ref int result, List<Digit> numbersPerLine)
	{
		int lineInt = 0;
		var orderedDict = numbersPerLine.OrderBy(x => x.Index);
		var thereisazero = orderedDict.Where(x => x.Value == 0);

		lineInt = int.Parse(orderedDict.First().Value.ToString() + orderedDict.Last().Value.ToString());
		result += lineInt;
	}

	private static void FindDigitsAsNumers(string line, List<Digit> numbersPerLine)
	{
		for (int i = 0; i < line.Length; i++)
		{
			char character = line[i];
			if (int.TryParse(character.ToString(), out var number))
			{
				if (number <= 0)
				{
					Console.WriteLine("A");
				}
				numbersPerLine.Add(new Digit { Index = i, Value = number });
			}
		}
	}

	private static void FindDigitsAsWords(string line, List<Digit> numbersPerLine)
	{
		foreach (var value in _searchValues)
		{
			int index = 0;
			while ((index = line.IndexOf(value.Value, index)) >= 0)
			{
				numbersPerLine.Add(new Digit { Index = index, Value = value.Key });
				index += value.Value.Length;

			}
		}
	}


}