using System;
using System.Linq;

class NumberOfDigits
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int result = 0;
        int product = 0;

        for (int i = 1; i <= input; i++)
        {
            product = i.ToString().Count();
            result += product;
        }

        Console.WriteLine(result);
    }
}