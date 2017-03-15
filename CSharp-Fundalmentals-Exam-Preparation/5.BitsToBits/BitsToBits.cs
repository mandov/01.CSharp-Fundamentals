using System;
using System.Text;

class BitsToBits
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        StringBuilder st = new StringBuilder();
        string binary = string.Empty;
        for (int i = 0; i < size; i++)
        {
            int number = int.Parse(Console.ReadLine());
            binary = Convert.ToString(number, 2);
            st.Append(new string('0', 30 - binary.Length) + binary);
        }

        int bestZeroSequence = 0;
        int bestOneSequence = 0;
        int currentOne = 0;
        int currentZero = 0;
        for (int i = 0; i < st.Length; i++)
        {
            if (st[i] == '0')
            {
                currentZero++;
                if (currentZero > bestZeroSequence)
                {
                    bestZeroSequence = currentZero;
                }
            }
            else
            {
                currentZero = 0;
            }

            if (st[i] == '1')
            {
                currentOne++;
                if (currentOne > bestOneSequence)
                {
                    bestOneSequence = currentOne;
                }
            }
            else
            {
                currentOne = 0;
            }
        }

        Console.WriteLine("{0}\n{1}", bestZeroSequence, bestOneSequence);
    }
}