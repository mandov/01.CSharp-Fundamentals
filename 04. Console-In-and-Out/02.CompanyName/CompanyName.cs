using System;

class CompanyName
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string mangaerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerNumber = Console.ReadLine();
        string a = string.Empty;

        Console.WriteLine(" {0}", companyName);
        Console.WriteLine("Address: {0}", companyAdress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber.Length == 0 ? "(no fax)" : faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, mangaerLastName, managerAge, managerNumber);
    }
}