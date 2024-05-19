using DayOne;

internal class Program
{
	static void Main(string[] args)
	{
		int result_day1 = Day1.Solve(File.ReadAllText(Helpers.Helpers.FindInputTxtFile("input_day1")));
		var result_day1 = Day2.Solve(File.ReadAllText(Helpers.Helpers.FindInputTxtFile("input_day1")));
	}
}