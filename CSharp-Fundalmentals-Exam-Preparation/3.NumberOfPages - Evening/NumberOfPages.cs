using System;
using System.Linq;

class NumberOfPages
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 1; 0 < input; i++)
        {
            result += 1;
            input -= i.ToString().Count();
        }
        Console.WriteLine(result);
    }
}