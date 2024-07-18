using FluentAssertions;

namespace ChallengeHub;

public class FindMaxUnitTest
{
    [Fact]
    public void ShouldReturnMaxValue()
    {
        FindMax.Find([1, 3, 7, 2, 5]).Should().Be(7, "7 é o maior elemento do array");
        FindMax.Find([-1, -3, -7, -2, -5]).Should().Be(-1, "-1 é o maior elemento do array de números negativos");
        FindMax.Find([10, 20, 30, 40, 50]).Should().Be(50, "50 é o maior elemento do array");
        FindMax.Find([5]).Should().Be(5, "o maior elemento de um array com um único elemento é o próprio elemento");
        FindMax.Find([0, 0, 0, 0]).Should().Be(0, "0 é o maior elemento do array de zeros");
    }
}