using System;

namespace Day6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical programming");
            //UC4_PrimeNumber
            Console.WriteLine("Welcome to reverse number Program");
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp, rem, rev = 0;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = ((rev * 10) + rem);
                num = num / 10;
            }

            Console.WriteLine("Reverse of the number " + temp + " is: " + rev);

        }
    }
}

        
   

    

