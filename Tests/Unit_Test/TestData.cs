using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test.Data;
public class TestData
{
	public static IEnumerable<object[]> Day1_testData()
	{
		// input, result
		yield return new object[] { @"three2fiveonexrllxsvfive", 35};
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
};