using System;

class PrimeCheck
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        bool isPrime = false;
        if (a < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int b = 2; b <= Math.Sqrt(a); b++)
            {
                if (a % b == 0)
                {
                    isPrime = false;
                }
            }
        }
      
        if (isPrime)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}