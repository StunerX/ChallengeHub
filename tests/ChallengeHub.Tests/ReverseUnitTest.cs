using FluentAssertions;

namespace ChallengeHub;

public class ReverseUnitTest
{
    [Fact]
    public void ShouldReverseArray()
    {
        Reverse.Array([1, 2, 3]).Should().Equal([3, 2, 1], "a ordem dos elementos deve ser invertida");
        Reverse.Array([4, 5, 6, 7]).Should().Equal([7, 6, 5, 4], "a ordem dos elementos deve ser invertida");
        Reverse.Array([]).Should().Equal([], "um array vazio deve continuar vazio quando invertido");
        Reverse.Array([9]).Should().Equal([9], "um array com um único elemento deve permanecer o mesmo quando invertido");
        Reverse.Array([-1, -2, -3]).Should().Equal([-3, -2, -1], "a ordem dos elementos negativos deve ser invertida");
    }
}