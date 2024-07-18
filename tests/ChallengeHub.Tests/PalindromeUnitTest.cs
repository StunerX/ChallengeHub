using FluentAssertions;

namespace ChallengeHub;

public class PalindromeUnitTest
{
    [Fact]
    public void ShouldValidatePalindrome()
    {
        Palindrome.IsPalindrome("racecar").Should().BeTrue("racecar é um palíndromo");
        Palindrome.IsPalindrome("hello").Should().BeFalse("hello não é um palíndromo");
        Palindrome.IsPalindrome("madam").Should().BeTrue("madam é um palíndromo");
        Palindrome.IsPalindrome("12321").Should().BeTrue("12321 é um palíndromo");
    }
}