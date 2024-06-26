using Solutions;
using FluentAssertions;

namespace Unit_Tests;

public class Day1_Tests
{
	[Theory]
	[MemberData(nameof(TestData.Day1_testData), MemberType = typeof(TestData))]
	public void Test1(string input, int solution)
	{
		//arrange

		//act
		var result =  Day1.Solve(input);
		//assert
		result.Should().Be(solution);
		result.Should().NotBe(null);
		result.Should().BeGreaterThanOrEqualTo(0);
	}
}