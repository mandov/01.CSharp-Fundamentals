using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("The value of int:{0}", a);
        Console.WriteLine("The value of double:{0}", b);
     
        a += 3;
        b += 2.6;
        Console.WriteLine("The value after adding a value to int:{0}", a);
        Console.WriteLine("The value after adding a value double:{0}", b);
        Console.WriteLine("When we adding a value on null values we get null");
    }
}