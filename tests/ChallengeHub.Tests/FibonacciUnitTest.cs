using FluentAssertions;

namespace ChallengeHub;

public class FibonacciUnitTest
{
    [Fact]
    public void ShouldReturnFibonacciWhenProvidePosition()
    {
        Fibonacci.GetFibonacci(0).Should().Be(0, "o 0º número da sequência de Fibonacci é 0");
        Fibonacci.GetFibonacci(1).Should().Be(1, "o 1º número da sequência de Fibonacci é 1");
        Fibonacci.GetFibonacci(2).Should().Be(1, "o 2º número da sequência de Fibonacci é 1");
        Fibonacci.GetFibonacci(3).Should().Be(2, "o 3º número da sequência de Fibonacci é 2");
        Fibonacci.GetFibonacci(4).Should().Be(3, "o 4º número da sequência de Fibonacci é 3");
        Fibonacci.GetFibonacci(5).Should().Be(5, "o 5º número da sequência de Fibonacci é 5");
        Fibonacci.GetFibonacci(6).Should().Be(8, "o 6º número da sequência de Fibonacci é 8");
        Fibonacci.GetFibonacci(7).Should().Be(13, "o 7º número da sequência de Fibonacci é 13");
    }
}