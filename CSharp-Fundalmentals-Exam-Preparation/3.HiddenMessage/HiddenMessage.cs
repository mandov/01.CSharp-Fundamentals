using System;
using System.Collections.Generic;
using System.Text;

class HiddenMessage
{
    static void Main()
    {
        List<string> data = new List<string>();
        int counter = 0;
        string test = string.Empty;

        while (test != "end")
        {
            data.Add(Console.ReadLine().Trim());
            test = data[counter];
            counter++;
        }

        StringBuilder st = new StringBuilder();
        string substring = string.Empty;
        string result = string.Empty;
        int startIndex = 0;
        int skipIndex = 0;
        string text = string.Empty;

        for (int i = 0, j = 1, c = 2; i <= data.Count; i += 3, j += 3, c += 3)
        {
            if (c > data.Count)
            {
                break;
            }

            startIndex = Convert.ToInt32(data[i]);
            skipIndex = Convert.ToInt32(data[j]);
            text = data[c];
            int start = startIndex;

            for (int x = start; x < text.Length; x += skipIndex)
            {
                if (startIndex == 0)
                {
                    st.Append(text.Substring(x, 1));
                }

                if (startIndex < 0)
                {
                    substring = text.Substring(text.Length - Math.Abs(startIndex), 1);
                    startIndex = 0;
                    st.Append(substring);
                }

                if (startIndex > 0)
                {
                    substring = text.Substring(startIndex, 1);
                    startIndex = 0;
                    st.Append(substring);
                }

            }
        }

        Console.WriteLine(st);
    }
}