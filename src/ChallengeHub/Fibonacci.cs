public class Fibonacci
{
    /// <summary>
    /// Descrição: Escreva uma função que retorne o n-ésimo número da sequência de Fibonacci.
    /// Exemplo: Fibonacci(7) retorna 13.
    /// A sequência de Fibonacci é um padrão numérico em que o primeiro e o segundo termo
    /// são iguais a 1 e cada termo a partir do terceiro é a soma dos dois termos anteriores.
    /// Sequencia: 0,1, 1, 2, 3, 5, 8 ....
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int GetFibonacci(int n)
    {
        if (n == 0 || n == 1)
        {
            return n;
        }
        else
        {
            int x = 0;
            int v = 1;

            for (int i = 1; i < n; i++)
            {
                int t = x + v;

                x = v;
                v = t;
            }

            return v;
        }
    }
}