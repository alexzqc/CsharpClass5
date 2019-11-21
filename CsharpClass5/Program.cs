using System;

namespace CsharpClass5
{
    class Program
    {  
        static void Main(string[] args)
        {
            int x = 1;
            int[] intArray = new int[] { 1, 2, 3 };

            Console.WriteLine(x);
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------------------------------");
            AddOne(x);
            AddOne(intArray);

            Console.WriteLine(x);
            foreach(int i in intArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void AddOne(int x)
        {
            x++;
        }
        static void AddOne(int[] intArray)
        {
            for (int i =0; i<intArray.Length;i++)
            {
                intArray[i]++;
            }
        }
    }
}

