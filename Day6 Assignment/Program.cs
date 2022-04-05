using System;

namespace Day6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical programming");
            //UC3_PrimeNumber
            Console.WriteLine("Welcome to prime number Program");
            Console.WriteLine("Enter a Number to Check prime or not: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Enetred Number " + num + " Is a prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
            Console.ReadLine();

        }
    }
}

        
   

    

