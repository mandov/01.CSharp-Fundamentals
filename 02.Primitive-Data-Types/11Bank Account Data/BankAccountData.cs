using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string secondName = "Slavov";
        decimal moneyBalance = 15135.515m;
        string iban = "39 FINV 9150 1003 5487 97";
        long creditCardNumber = 4521542178516451;
     
        Console.WriteLine(" First Name:{0} \n Middle Name:{1} \n Second Name:{2} \n Money Balance:{3} \n IBAN:{4} \n Credit Card Number:{5}", firstName, middleName, secondName, moneyBalance, iban, creditCardNumber);
    }
}