namespace ChallengeHub;

public class Reverse
{
    /// <summary>
    /// Escreva uma função que inverta a ordem dos elementos em um array de inteiros.
    /// Exemplo: ReverseArray(new int[] {1, 2, 3}) retorna {3, 2, 1}.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static int[] Array(int[] array)
    {
        int[] reverseInt = new int[array.Length];
        int z = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            reverseInt[z++] = array[i];
        }
        return reverseInt;
    }
}

