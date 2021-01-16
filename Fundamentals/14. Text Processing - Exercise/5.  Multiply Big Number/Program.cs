using System;
using System.Numerics;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());

            BigInteger b = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(a*b);
        }
    }
}
