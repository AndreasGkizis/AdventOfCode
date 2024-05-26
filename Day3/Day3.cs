using Helpers;
namespace Solutions;

public static class Day3
{
	public static int SolvePart1(string input)
	{
		int totalSum = 0;
		var rows = input.SplitAtNewLine();
		int rowCount = rows.Length;
		int colCount = rows[0].Length;
		char[,] twoDimentionalArray = new char[rowCount, colCount];
		// create a 2d array of chars
		for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
				twoDimentionalArray[i, j] = rows[i][j];
            }
        }
		//traverse the array row by row
		// check for symols in proximity
		// add to sum if symbols in proximity


        return totalSum;
	}
}
