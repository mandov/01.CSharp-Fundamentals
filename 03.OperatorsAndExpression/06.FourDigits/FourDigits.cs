using System;

class Program
{
    static void Main()
    {
        int digit = int.Parse(Console.ReadLine());
        int a = digit / 1000;
        int b = (digit / 100) % 10;
        int c = (digit / 10) % 10;
        int d = digit % 10;

        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}