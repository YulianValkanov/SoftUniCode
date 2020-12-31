using System;

namespace USD
{
    class Program
    {
        static void Main(string[] args)
        {

            int USD = int.Parse(Console.ReadLine());

            double BGN = 1.79549 * USD;

            Console.WriteLine($"{BGN:f3}");
        }
    }
}
