using System;

class thirthdBit
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << 3;
            int nanmask = a & mask;
            int bit = nanmask >> p;

            Console.WriteLine(bit);
        }
    }
