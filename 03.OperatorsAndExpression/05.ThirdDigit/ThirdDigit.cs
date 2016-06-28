using System;

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int getThirdDigit = (number / 100) % 10;

        if (getThirdDigit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", getThirdDigit);
        }
    }
}