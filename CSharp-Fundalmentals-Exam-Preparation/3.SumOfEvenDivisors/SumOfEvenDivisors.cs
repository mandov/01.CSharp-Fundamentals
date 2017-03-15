using System;

class SumOfEvenDivisors
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = a; i <= b; i++)
        {
            for (int j = 2; j <= i; j++)
            {
                if (j % 2 == 0 && i % j == 0)
                {
                    sum += j;
                }
            }
        }

        Console.WriteLine(sum);
    }
}