using System;

class ModifyBit
{
    static void Main()
    {
        long n = int.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());

        if (v == 0)
        {
            ulong mask = (ulong)~(1 << p);
            ulong nMask = (ulong)n & mask;

            Console.WriteLine(nMask);
        }
        if (v == 1)
        {
            ulong masktwo = (ulong)1 << p;
            ulong nMasktwo =(ulong) n | masktwo;

            Console.WriteLine(nMasktwo);
        }
    }
}