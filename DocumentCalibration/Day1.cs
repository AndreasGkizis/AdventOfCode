using System.Buffers;

namespace DayOne;

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
			int lineInt;
			// index , int
			Dictionary<int, int> numbersPerLine = new();
			foreach (var value in _searchValues)
			{
				var index = line.IndexOf(value.Value);
				if (index >= 0)
				{
					numbersPerLine.Add(index, value.Key);
				}
			}

			for (int i = 0; i < line.Length; i++)
			{
				char character = line[i];
				if (int.TryParse(character.ToString(), out var number))
				{
					if (number <= 0)
					{
                        Console.WriteLine("A");
                    }
					numbersPerLine.Add(i, number);
				}
			}

			if (numbersPerLine.Count > 0)
			{
				var orderedDict = numbersPerLine.OrderBy(x => x.Key).ThenBy(x => x.Value);
				var thereisazero = orderedDict.Where(x => x.Value == 0);

				lineInt = int.Parse(orderedDict.First().Value.ToString() + orderedDict.Last().Value.ToString());
				result += lineInt;
			}
		}
		return result;
	}
}