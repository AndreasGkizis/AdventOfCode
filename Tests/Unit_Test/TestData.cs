namespace Unit_Test.Data;
public class TestData
{
	public static IEnumerable<object[]> Day1_testData()
	{
		// input, result
		yield return new object[] { @"three2fiveonexrllxsvfive", 35 };
		yield return new object[] { @"tgppgp9", 99 };
		yield return new object[] { @"2aaa2aaaa2", 22 };
		yield return new object[] { @"1asdasxcasfedw2", 12 };
		yield return new object[] { @"sixsix", 66 };
		yield return new object[] { @"66", 66 };
		yield return new object[] { @"eighthree", 83 };
		yield return new object[] { @"eightthree", 83 };
		yield return new object[] { @"sevenine", 79 };
		yield return new object[] { @"twone", 21 };
		yield return new object[] { @"twoone", 21 };
		yield return new object[] { @"two1nine
eightwothree
abcone2threexyz
xtwone3four
4nineeightseven2
zoneight234
7pqrstsixteen", 281 };
	}
	public static IEnumerable<object[]> Day2_testData_part1()
	{
		// input, result
		yield return new object[] { @"Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green
", 8 };
	}

	public static IEnumerable<object[]> Day2_testData_part2()
	{
		// input, result
		yield return new object[] { @"Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green
", 2286 };
	}
};