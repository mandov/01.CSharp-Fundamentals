using System;

    class nthBit
    {
        static void Main()
        {
            int p = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            long mask = 1 << p;
            long nAndMask = n & mask;
            long bit = nAndMask >> p;

            Console.WriteLine(bit);
        }
    }