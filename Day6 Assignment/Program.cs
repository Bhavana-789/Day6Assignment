using System;

namespace Day6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical programming");
            //UC2_PerfectNumber
            Console.WriteLine("Welcome to perfect number Program");
            int temp, sum = 0;
            Console.Write("enter the Number");
            int num = int.Parse(Console.ReadLine());
            temp = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == temp)
            {
                Console.WriteLine("Entered number " + num + " is a perfect number");
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
            }
        }
    }
}
        
   

    

