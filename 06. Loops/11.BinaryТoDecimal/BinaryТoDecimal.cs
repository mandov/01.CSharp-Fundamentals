using System;

class BinaryТoDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        int power = 1;
        int decimalNumber = 0;

        for (int i = binaryNumber.Length - 1; i >= 0 ; i--)
        {
            int number = binaryNumber[i] - 48;
            decimalNumber += number * power;
            power *= 2;
        }
        Console.WriteLine(decimalNumber);
    }
}