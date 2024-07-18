using FluentAssertions;

namespace ChallengeHub;

public class TransposeMatrixUnitTest
{
    [Fact]
    public void ShouldConvertWhenTransposeMatrix()
    {
        int[,] matrix1 = 
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        int[,] expected1 = 
        {
            { 1, 4 },
            { 2, 5 },
            { 3, 6 }
        };
        TransposeMatrix.Convert(matrix1).Should().BeEquivalentTo(expected1, "a matriz transposta deve ter linhas e colunas trocadas");

        int[,] matrix2 = 
        {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };
        int[,] expected2 = 
        {
            { 7, 9, 11 },
            { 8, 10, 12 }
        };
        TransposeMatrix.Convert(matrix2).Should().BeEquivalentTo(expected2, "a matriz transposta deve ter linhas e colunas trocadas");

        int[,] matrix3 = 
        {
            { 1 }
        };
        int[,] expected3 = 
        {
            { 1 }
        };
        TransposeMatrix.Convert(matrix3).Should().BeEquivalentTo(expected3, "a matriz transposta de uma matriz 1x1 deve ser a própria matriz");

        int[,] matrix4 = 
        {
            { }
        };
        int[,] expected4 = 
        {
            { }
        };
        TransposeMatrix.Convert(matrix4).Should().BeEquivalentTo(expected4, "a matriz transposta de uma matriz vazia deve ser uma matriz vazia");
    }
}