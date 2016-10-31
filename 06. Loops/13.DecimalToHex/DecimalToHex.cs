using System;

class DecimalToHex
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        long remainder = 0;
        string hexNumber = string.Empty;

        if (decimalNumber == 0)
        {
            hexNumber ="0";
        }
        else
        {
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 16;
                decimalNumber /= 16;
                switch (remainder)
                {
                    case 10: hexNumber = hexNumber + "A";break;
                    case 11: hexNumber = hexNumber + "B";break;
                    case 12: hexNumber = hexNumber + "C"; break;
                    case 13: hexNumber = hexNumber + "D"; break;
                    case 14: hexNumber = hexNumber + "E"; break;
                    case 15: hexNumber = hexNumber + "F"; break;                                             
                    default: hexNumber = remainder + hexNumber;break;                      
                }
            }
        }
        Console.WriteLine(hexNumber);
    }
}
