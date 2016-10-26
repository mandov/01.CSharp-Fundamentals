using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        double doublenumber;
        int intnumber;
        switch (input)
        {
            case "text": input = Console.ReadLine(); Console.WriteLine("{0}*", input); break;
            case "real": doublenumber = double.Parse(Console.ReadLine()); Console.WriteLine("{0:F2}", doublenumber + 1); break;
            case "integer": intnumber = int.Parse(Console.ReadLine()); Console.WriteLine("{0}", intnumber + 1); break;
            default: Console.WriteLine("fuck u"); break;
        }
    }
}