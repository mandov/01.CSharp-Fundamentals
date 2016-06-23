using System;

class StringsAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object c = "Hello World";
        string d = (string) c;
        Console.WriteLine("{0} {1}\n{2} \n{3}",a ,b ,c ,d);
    }
}