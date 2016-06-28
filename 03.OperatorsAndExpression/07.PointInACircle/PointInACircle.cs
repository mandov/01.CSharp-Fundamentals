using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 2 * 2;
        double distance = (x * x) + (y * y);

        if (distance <= radius)
        {
            Console.WriteLine("yes {0:F2}", Math.Sqrt(distance));
        }
        else
        {
            Console.WriteLine("no {0:F2}", Math.Sqrt(distance));
        }
    }
}