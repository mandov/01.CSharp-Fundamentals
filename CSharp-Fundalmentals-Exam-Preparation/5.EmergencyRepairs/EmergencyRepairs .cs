using System;
using System.Collections.Generic;

class EmergencyRepairs
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string st = Convert.ToString((long)number, 2).PadLeft(64, '0');
        int emergencyKit = int.Parse(Console.ReadLine());
        int attacks = int.Parse(Console.ReadLine());
        List<char> bits = new List<char>(st);
        bits.Reverse();
        for (int i = 0; i < attacks; i++)
        {
            int attackPosition = int.Parse(Console.ReadLine());
            bits[attackPosition] = '0';
        }

        int nullCounter = 0;
        for (int i = 0; i < bits.Count; i++)
        {
            while (bits[i] == '0')
            {
                nullCounter++;
                i++;
                if (i >= bits.Count)
                {
                    break;
                }
            }

            if (nullCounter >= 2)
            {
                for (int j = i - nullCounter; j < i; j++)
                {
                    if (emergencyKit == 0)
                    {
                        break;
                    }

                    bits[j] = '1';
                    emergencyKit--;
                }
            }

            if (emergencyKit == 0)
            {
                break;
            }

            nullCounter = 0;
        }

        bits.Reverse();
        ulong final = Convert.ToUInt64(string.Join("", bits), 2);
        Console.WriteLine(final);
    }
}