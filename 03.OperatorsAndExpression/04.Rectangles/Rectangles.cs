using System;

class Rectangle
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = (2 * width) + (2 * height);
        double area = height * width;

        Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
    }
}