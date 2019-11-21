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

            structAccount.AddMonthlyInterest();
            classAccount.AddMonthlyInterest();

            structAccount.ShowDetails("Original Struct Account");
            classAccount.ShowDetails("Original Struct Account");

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

