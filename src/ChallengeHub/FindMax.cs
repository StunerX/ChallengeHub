namespace ChallengeHub;

public class FindMax
{
    /// <summary>
    /// Escreva uma função que encontre o maior elemento em um array de inteiros.
    /// Exemplo: FindMax(new int[] {1, 3, 7, 2, 5}) retorna 7.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static int Find(int[] array)
    {
        int valorMaximo = int.MinValue;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > valorMaximo)
            {
                valorMaximo = array[i];
            }
        }

        return valorMaximo;
    }
}