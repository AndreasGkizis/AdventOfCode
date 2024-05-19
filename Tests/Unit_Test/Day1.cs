using DayOne;
using FluentAssertions;

namespace Unit_Test
{
	public class Day1_tests
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
}