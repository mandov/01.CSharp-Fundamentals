using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class SaddyKopper
{
    static void Main()
    {
        string n = Console.ReadLine();
        long evenResult = 0;
        int transformations = 0;
        BigInteger sumResult = 1;

        StringBuilder st = new StringBuilder(n);
        List<long> sum = new List<long>();

        while (st.Length != 0)
        {
            st.Remove(st.Length - 1, 1);
            for (int j = 0; j < st.Length; j++)
            {
                if (j % 2 == 0 && st.Length > 0)
                {
                    evenResult += st[j] - 48;
                }
            }

            if (st.Length > 0)
            {
                sum.Add(evenResult);
            }

            evenResult = 0;

            if (st.Length == 0)
            {
                transformations++;
                for (int i = 0; i < sum.Count; i++)
                {
                    sumResult *= sum[i];
                }

                if (sumResult.ToString().Length > 1)
                {
                    st.Append(sumResult);
                }
                else
                {
                    st.Append(sumResult.ToString());
                    break;
                }

                sumResult = 1;
                sum.Clear();
            }

            if (transformations == 10)
            {
                break;
            }
        }

        if (transformations < 10)
        {
            Console.WriteLine(transformations);
            Console.WriteLine(st);
        }
        else
        {
            Console.WriteLine(st);
        }
    }
}