using FluentAssertions;
using Solutions;

namespace Unit_Tests;

public class Day2_Tests
{
	[Theory]
	[MemberData(nameof(TestData.Day2_testData_part1), MemberType = typeof(TestData))]
	public void Test_Part1(string input, int solution)
	{
		//arrange

		//act
		var result = Day2.SolvePart1(input);
		//assert
		result.Should().Be(solution);
		result.Should().NotBe(null);
		result.Should().BeGreaterThanOrEqualTo(0);
	}
	
	[Theory]
	[MemberData(nameof(TestData.Day2_testData_part2), MemberType = typeof(TestData))]
	public void Test_Part2(string input, int solution)
	{
		//arrange

		//act
		var result = Day2.SolvePart2(input);
		//assert
		result.Should().Be(solution);
		result.Should().NotBe(null);
		result.Should().BeGreaterThanOrEqualTo(0);
	}
}