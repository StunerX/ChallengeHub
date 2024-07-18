using FluentAssertions;

namespace ChallengeHub;

public class LeapYearUnitTest
{
    [Fact]
    public void ShouldReturnTrueWhenIsLeapYear()
    {
        LeapYear.IsLeapYear(2000).Should().BeTrue("2000 é um ano bissexto");
        LeapYear.IsLeapYear(2004).Should().BeTrue("2004 é um ano bissexto");
        LeapYear.IsLeapYear(2008).Should().BeTrue("2008 é um ano bissexto");
        LeapYear.IsLeapYear(2012).Should().BeTrue("2012 é um ano bissexto");
        LeapYear.IsLeapYear(2016).Should().BeTrue("2016 é um ano bissexto");
        LeapYear.IsLeapYear(2020).Should().BeTrue("2020 é um ano bissexto");
    }
}