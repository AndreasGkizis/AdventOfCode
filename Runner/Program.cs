using Solutions;

internal class Program
{
	static void Main(string[] args)
	{
		int result_day1 = Day1.Solve(File.ReadAllText(Helpers.Helpers.FindInputTxtFile("input_day1")));
		var result_day2_part1 = Day2.SolvePart1(File.ReadAllText(Helpers.Helpers.FindInputTxtFile("input_day2")));
		var result_day2_part2 = Day2.SolvePart2(File.ReadAllText(Helpers.Helpers.FindInputTxtFile("input_day2")));
		var result_day3_part1 = Day3.SolvePart1(File.ReadAllText(Helpers.Helpers.FindInputTxtFile("input_day3")));

		Console.WriteLine("bla");
	}
}