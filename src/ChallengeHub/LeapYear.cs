namespace ChallengeHub;

public class LeapYear
{
    /// <summary>
    /// Escreva uma função que verifique se um ano é bissexto.
    /// Os anos bissextos foram criados no Império Romano. Eles possuem 366 dias e acontecem em
    /// anos divisíveis por quatro, exceto quando terminados em 00
    /// Exemplo: IsLeapYear(2020) retorna true, IsLeapYear(2019) retorna false.
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && !(year % 100 == 0);
    }
}