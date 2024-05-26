using FluentAssertions;
using Solutions;

namespace Unit_Tests;

public class Day2_Tests
{
	[Theory]
	[MemberData(nameof(TestData.Day2_testData), MemberType = typeof(TestData))]
	public void Test1(string input, int solution)
	{
		//arrange

		//act
		var result = Day2.Solve(input);
		//assert
		result.Should().Be(solution);
		result.Should().NotBe(null);
		result.Should().BeGreaterThanOrEqualTo(0);
	}
}