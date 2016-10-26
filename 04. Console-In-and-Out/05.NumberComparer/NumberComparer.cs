using System;

class NumberCompare
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int compare = a > b ? a : b;

        Console.WriteLine(compare);

    }
}