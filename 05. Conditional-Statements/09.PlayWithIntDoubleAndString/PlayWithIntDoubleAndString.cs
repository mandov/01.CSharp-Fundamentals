using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        string a = Console.ReadLine();
        int firstChoice;
        double secondChoice;
        string thirdChoice;

        switch (a)
        {
            case "integer":
                firstChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(firstChoice + 1);
                break;
            case "real":
                secondChoice = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", secondChoice + 1);
                break;
            case "text": thirdChoice = Console.ReadLine();
                Console.WriteLine(thirdChoice + '*');
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}
