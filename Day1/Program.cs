using DayOne;
internal class Program
{
	private static void Main(string[] args)
	{
		var inputFile = Helpers.Helpers.FindInputTxtFile();
		var result = Day1.Solve(File.ReadAllText(inputFile));
	}
}