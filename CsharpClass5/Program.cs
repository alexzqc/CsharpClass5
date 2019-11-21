using System;

namespace CsharpClass5
{
    class Program
    {   struct BankAccountStruct
        {
            public string Name { get; set; }
            public float Balance { get; set; }

            public BankAccountStruct(string name, float balance)
            {
                Name = name;
                Balance = balance;
            }

            public void AddMonthlyInterest()
            {
                Balance *= (1f + .056f / 12f);
            }

            public void ShowDetails(string title)
            {
                Console.WriteLine($"Title: {title} \n Name: {Name} \n Balance: {Balance.ToString("C")}");
            }
        }

        class BankAccountClass
        {
            public string Name { get; set; }
            public float Balance { get; set; }

            public BankAccountClass(string name, float balance)
            {
                Name = name;
                Balance = balance;
            }

            public void AddMonthlyInterest()
            {
                Balance *= (1f +.056f / 12f);
            }

            public void ShowDetails(string title)
            {
                Console.WriteLine($"Title: {title} \n Name: {Name} \n Balance: {Balance.ToString("C")}");
            }
        }
        static void Main(string[] args)
        {
            const string NAME = "Object Name";
            const float BALANCE = 593473.03f;

            BankAccountStruct structAccount = new BankAccountStruct(NAME,BALANCE);
            BankAccountClass classAccount = new BankAccountClass(NAME, BALANCE);

            BankAccountStruct copyStructAccount = structAccount;

            BankAccountClass copyClassAccount = classAccount;

            structAccount.ShowDetails("Original Struct Account");
            copyStructAccount.ShowDetails("Copy Struct Account");
            Console.WriteLine();

            classAccount.ShowDetails("Original Class Account");
            copyClassAccount.ShowDetails("Copy Class Account");

            Console.WriteLine();

            copyStructAccount.AddMonthlyInterest();
            copyClassAccount.AddMonthlyInterest();

            structAccount.ShowDetails("Original Struct Account");
            copyStructAccount.ShowDetails("Copy Struct Account");

            Console.WriteLine();

            classAccount.ShowDetails("Original Class Account");
            copyClassAccount.ShowDetails("Copy Class Account");


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

