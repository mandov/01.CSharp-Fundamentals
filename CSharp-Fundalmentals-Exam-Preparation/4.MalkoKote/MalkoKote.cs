using System;

class MalkoKote
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        int patternPlus = ((size / 4) + 1);
        int patternMinus = ((size / 4) - 1);

        // ears
        char whiteSpace = ' ';
        Console.WriteLine("{0}{1}{2}{1}", new string(' ', size / size), new string(symbol, 1), new string(' ', patternMinus));

        // head
        for (int i = 0; i < (size / 4) - 1; i++)
        {
            Console.WriteLine("{0}{1}", new string(whiteSpace, 1), new string(symbol, patternPlus));
        }

        // neck
        for (int i = 0; i < size / 6; i++)
        {
            Console.WriteLine("{0}{1}", new string(whiteSpace, 2), new string(symbol, patternMinus));
        }

        // body
        for (int i = 1; i <= size / 5; i++)
        {
            if (i != (size / 5))
            {
                Console.WriteLine("{0}{1}", whiteSpace, new string(symbol, patternPlus));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{3}", whiteSpace, new string(symbol, patternPlus), new string(' ', 3), new string(symbol, (size / 4)));
            }
        }

        // down body
        for (int i = 1; i <= (size / 4) + 2; i++)
        {
            if (i != (size / 4) + 2)
            {
                Console.WriteLine("{0}{1}{2}", new string(symbol, ((size / 4) + 3)), new string(' ', 2), symbol);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", new string(symbol, ((size / 4) + 3)), whiteSpace, new string(symbol, 2));
            }
        }

        Console.WriteLine("{0}{1}", whiteSpace, new string(symbol, (size / 4) + 4));
    }
}