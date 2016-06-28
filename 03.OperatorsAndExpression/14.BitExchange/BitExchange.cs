using System;


class bitExchange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
       
        int mask = 1 << 3;
        int thirthBit = (number & mask) >> 3;

        mask = 1 << 24;
        int twentyFourthBit = (number & mask) >> 24;

        if (thirthBit == 0)
        {
            mask = ~(1 << 24);
            number = number & mask;
        }
        else if (thirthBit == 1)
        {
            mask = 1 << 24;
            number = number | mask;
        }

        if (twentyFourthBit == 0)
        {
            mask = ~(1 << 3);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            mask = 1 << 3;
            number = number | mask;
        }

        mask = 1 << 4;
        int fourthBit = (number & mask) >> 4;

        mask = 1 << 25;
        int twentyFifthBit = (number & mask) >> 25;

        if (fourthBit == 0)
        {
            mask = ~(1 << 25);
            number = number & mask;
        }
        else if (fourthBit == 1)
        {
            mask = 1 << 25;
            number = number | mask;
        }
        if (twentyFifthBit == 0)
        {
            mask = ~(1 << 4);
            number = number & mask;
        }
        else if (twentyFifthBit == 1)
        {
            mask = 1 << 4;
            number = number | mask;
        }

        mask = 1 << 5;
        int fifthBit = (number & mask) >> 5;

        mask = 1 << 26;
        int twentySixthBit = (number & mask) >> 26;

        if (fifthBit == 0)
        {
            mask = ~(1 << 26);
            number = number & mask;
        }
        else if (fifthBit == 1)
        {
            mask = 1 << 26;
            number = number | mask;
        }
        if (twentySixthBit == 0)
        {
            mask = ~(1 << 5);
            number = number & mask;
        }
        else if (twentySixthBit == 1)
        {
            mask = 1 << 5;
            number = number | mask;
        }

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}