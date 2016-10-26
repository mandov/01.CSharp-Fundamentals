using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger previousNumber = -1;
        BigInteger currentNumber = 1;
        BigInteger fibonacciNumber = 0;

        for (int i = 0; i < n; i++)
        {
            fibonacciNumber = previousNumber + currentNumber;
            if (i != n - 1)
            {
                Console.Write(fibonacciNumber +",");
            }
            else
            {
                Console.Write(fibonacciNumber);
            }
            previousNumber = currentNumber;
            currentNumber = fibonacciNumber;
           
        }
    }
}
