using System;

namespace Day6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical programming");
            int num1 = 0, num2 = 1, temp, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            for (i = 2; i < number; ++i)
            {
                temp = num1 + num2;
                Console.Write(temp + " ");
                num1 = num2;
                num2 = temp;
            }
        }
    }
}
    

