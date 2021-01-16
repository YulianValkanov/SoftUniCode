using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            FormulOddSum(Array);
        }

        private static void FormulOddSum(int[] Array)
        {
            int sumEven = 0;

            int sumOdd = 0;

            foreach (int Digit in Array)
            {
                if (Digit % 2 == 0)
                {
                    sumEven += Digit;
                }
                else
                {
                    sumOdd += Digit;
                }
            }
            Console.WriteLine(sumEven);

            Console.WriteLine(sumOdd);

            Console.WriteLine(sumEven-sumOdd);
        }
    }
}
