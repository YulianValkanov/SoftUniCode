using System;
using System.Numerics;

namespace _2._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger number = 1;

            for (int i = n; i > 0; i--)
            {
                number *= i;
                
            }

            Console.WriteLine(number);
        }
    }
}
