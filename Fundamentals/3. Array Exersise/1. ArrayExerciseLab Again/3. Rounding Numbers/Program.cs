using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Array = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < Array.Length; i++)
            {


                double Rounding = Math.Round(Array[i]);
                Console.WriteLine($"{Array[i]} => {Rounding} ");
            }



        }
    }
}
