using System;

class HexToDecimal
{
    static void Main()
    {
        string hexadecimal = Console.ReadLine();

        int number = 0;
        int decNumber = 0;
        int power = 1;
        for (int i = hexadecimal.Length - 1; i >= 0; i--)
        {
            switch (hexadecimal[i])
            {
                case 'A': number = 10 ;break;
                case 'B': number = 11 ;break;
                case 'C': number = 12; break;
                case 'D': number = 13; break;
                case 'E': number = 14; break;
                case 'F': number = 15; break;            
                default:number= (int)hexadecimal[i] - 48;break;                  
            }
            decNumber += number * power;
            power *= 16;
        }
        Console.WriteLine(decNumber);
    } 

}