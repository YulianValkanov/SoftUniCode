using System;

namespace _4._Methood_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Print(n);
        }

        static void Print (int number)
        {
            if (number<0)
            {
                Console.WriteLine($"The number {number} is negative");
            }
            else if (number>0)
            {
                Console.WriteLine($"The number {number} is positive");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero");
            }
        }
    }
}
