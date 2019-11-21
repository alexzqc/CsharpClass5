using System;

namespace CsharpClass5
{
    class Program
    {
        struct BankAccountStruct
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
                Balance *= (1f + .056f / 12f);
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
            BankAccountStruct structAccount = new BankAccountStruct(NAME, BALANCE);
            BankAccountClass classAccount = new BankAccountClass(NAME, BALANCE);

            structAccount.ShowDetails("Original Struct Account");
            classAccount.ShowDetails("Original Class Account");


            Console.WriteLine("----------------------------------------------------");
            Add100(structAccount);
            Add100(classAccount);
            structAccount.ShowDetails("Original add100 Struct Account");
            classAccount.ShowDetails("Original add100 Class Account");


            Console.WriteLine("----------------------------------------------------");
            structAccount.Balance = Add100(structAccount.Balance);
            classAccount.Balance = Add100(classAccount.Balance);
            structAccount.ShowDetails("Original add 200 Struct Account");
            classAccount.ShowDetails("Original add 200 Class Account");

            Console.ReadLine();
        }

        static void Add100(BankAccountStruct structAccount)
        {
            structAccount.Balance += 100;
        }

        static void Add100(BankAccountClass classAccount)
        {
            classAccount.Balance += 100;
        }

        static float Add100(float balance)
        {
           return balance += 100;
        }
    }
}

