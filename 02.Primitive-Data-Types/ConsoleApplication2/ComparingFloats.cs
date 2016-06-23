using System;

class NullValues
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool comparing = Math.Abs(a - b) < eps;

        if (comparing)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }

    }
}
