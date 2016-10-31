using System;
using System.Linq;

class GreatestCommonDivisor
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long factoriel = 1;

        for (int i = 1; i <= a; i++)
        {
            factoriel *= i;
        }
        string factorielTwo = Convert.ToString(factoriel);
        long result = 0;
        for (int i = factorielTwo.Length - 1; i >= 0; i--)
        {
            long number = factorielTwo[i] - 48;
            if (number == 0)
            {
                result += 1;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(result);
    }
}