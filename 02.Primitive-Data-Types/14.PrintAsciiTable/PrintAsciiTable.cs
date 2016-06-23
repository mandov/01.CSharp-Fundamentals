using System;
using System.Text;

class PrintAsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int ascii = 33; ascii <= 126; ascii++)
        {
            Console.WriteLine((char)ascii);
        }
    }
}