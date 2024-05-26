using Helpers;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Solutions;

public enum DiceColours
{
	RED = 1,
	GREEN = 2,
	BLUE = 3,
}
public class Game
{
	public DiceSet BLUE { get; set; }

	public DiceSet RED { get; set; }
	public DiceSet GREEN { get; set; }
}

public class DiceSet
{
	public int Count { get; set; }
	public DiceColours Colour { get; set; }
}
public static class Day2
{
	private static readonly char[] _splitSeparator = new[] { '\n' };

	public static Game BagContents = new Game
	{
		BLUE = new DiceSet { Count = 14, Colour = DiceColours.BLUE },
		RED = new DiceSet { Count = 12, Colour = DiceColours.RED },
		GREEN = new DiceSet { Count = 13, Colour = DiceColours.GREEN }
	};

	public static int SolvePart2(string input)
	{
		int totalSumOfPower = 0;
		Dictionary<int, string> gamesDict = new();
		var games = input.SplitAtNewLine();

		for (int i = 0; i < games.Length; i++)
		{
			gamesDict.Add(i, games[i].Split(':')[1]);

			var blueDiceMax = MaxDiceNeeded(gamesDict[i], DiceColours.BLUE);
			var redDiceMax = MaxDiceNeeded(gamesDict[i], DiceColours.RED);
			var greenDiceMax = MaxDiceNeeded(gamesDict[i], DiceColours.GREEN);

			var gamePower = blueDiceMax * redDiceMax * greenDiceMax;
			totalSumOfPower += gamePower;
		}
		return totalSumOfPower;
	}

	private static int MaxDiceNeeded(string game, DiceColours colour)
	{
		var matches = FindColourMatchesInGame(game, colour);
		int max = 0;
		foreach (var match in matches)
		{
			var num = ParseIntoNumber(match, colour);
			if (num > max)
			{
				max = num;
			}
		}
		return max;
	}

	private static int ParseIntoNumber(Match match, DiceColours colour)
	{
		return int.Parse(match.Value.Replace(colour.ToString(), "", StringComparison.OrdinalIgnoreCase).Trim());
	}


	public static int SolvePart1(string input)
	{
		int sumOfIds = 0;
		Dictionary<int, string> gamesDict = new();
		var games = input.SplitAtNewLine();

		for (int i = 0; i < games.Length; i++)
		{
			gamesDict.Add(i, games[i].Split(':')[1]);

			var blueDice = IsGameValid(gamesDict[i], DiceColours.BLUE);
			var redDice = IsGameValid(gamesDict[i], DiceColours.RED);
			var greenDice = IsGameValid(gamesDict[i], DiceColours.GREEN);

			if (blueDice && redDice && greenDice)
			{
				sumOfIds += i + 1;
			}
		}
		return sumOfIds;
	}

	// does any single draw go over the max ammount of dice per colour?
	private static bool IsGameValid(string game, DiceColours colour)
	{
		var matches = FindColourMatchesInGame(game, colour);

		int dicePerGame = 0;
		foreach (var match in matches)
		{
			var diceCount = ParseIntoNumber(match, colour);
			var bagDiceSet = GetDiceSetByColour(BagContents, colour);

			if (diceCount > bagDiceSet.Count)
			{
				return false;
			}
			dicePerGame += diceCount;
		}
		return true;
	}

	public static DiceSet GetDiceSetByColour(Game game, DiceColours colour)
	{
		PropertyInfo property = typeof(Game).GetProperty(colour.ToString());
		return property?.GetValue(game) as DiceSet;
	}

	private static IEnumerable<Match> FindColourMatchesInGame(string game, DiceColours colour)
	{
		// more than 5 letters word will break this 
		string pattern = @"\d+\s\w{1,5}";
		return Regex.Matches(game, pattern).Where(match => match.Success == true && match.Value.EndsWith(colour.ToString(), StringComparison.OrdinalIgnoreCase));
	}
}
