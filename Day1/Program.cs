using DayOne;
using Helpers;
internal class Program
{
	private static void Main(string[] args)
	{
		var inputFile = Helpers.Helpers.FindInputTxtFile();
		var result = Day1.Solve(File.ReadAllText(inputFile));
		Console.WriteLine(result);
	}
}