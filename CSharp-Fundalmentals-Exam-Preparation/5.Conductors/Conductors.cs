using System;
using System.Text;
using System.Text.RegularExpressions;

class Conductors
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] tickets = new int[n];

        for (int i = 0; i < n; i++)
        {
            tickets[i] = int.Parse(Console.ReadLine());
        }
        string perforatorBits = Convert.ToString(p, 2);
        string binaryNum = string.Empty;
        string rejectBytes = string.Empty;
        string resulttt = string.Empty;
        string finalno = string.Empty;
        int and = 0;
        int intToInt = 0;
        int d = 0;
        for (int i = 0; i <= tickets.Length - 1; i++)
        {
            binaryNum = Convert.ToString(tickets[i], 2);
            rejectBytes = binaryNum;
            string result = binaryNum;
            StringBuilder s = new StringBuilder();

            StringBuilder binary = new StringBuilder(Reverse(binaryNum));


            for (int j = 0; j < binaryNum.Length / perforatorBits.Length; j++)
            {
                string bytes = binary.ToString().Substring(binary.Length - perforatorBits.Length);
                int length = binary.Length - perforatorBits.Length;
                and = Convert.ToInt32(bytes);
                intToInt = and & p;
                StringBuilder readSubstring = new StringBuilder(bytes);
                binary.Remove(length, perforatorBits.Length);
                string substringReverse = Reverse(bytes);
                if (p == intToInt)
                {
                    readSubstring.Replace(substringReverse, new string('0', perforatorBits.Length));
                    resulttt = readSubstring + resulttt;
                    d = 1;
                }           
                if (d != 1)
                {
                    and = Convert.ToInt32(Reverse(bytes));
                    intToInt = and & p;
                    if (p == intToInt)
                    {
                        readSubstring.Replace(bytes, new string('0', perforatorBits.Length));
                        resulttt = readSubstring + resulttt;
                        d = 1;
                    }
                    if (d != 1)
                    {
                        
                        resulttt = Reverse(readSubstring.ToString()) + resulttt;

                    }
                }
                
                d = 0;

            }
        }
        Console.WriteLine(Reverse(resulttt));

    }

    static string Reverse(string chars)
    {
        char[] result = chars.ToCharArray();
        Array.Reverse(result);
        return new string(result);
    }
}