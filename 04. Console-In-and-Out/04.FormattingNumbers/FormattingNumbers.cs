﻿using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        string d = Convert.ToString(a, 2);

        Console.WriteLine("{0,-10:X} | {1} | {2,10:F2} | {3,-10:F3} |", a, d, b, c);
    }
}