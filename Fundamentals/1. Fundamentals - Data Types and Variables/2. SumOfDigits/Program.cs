using System;

namespace _2._SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int Imput = int.Parse(Console.ReadLine());

            int Number = Imput;

            int Digit = 0;

            int DigitSum = 0;

            while (Number>0)
            {
                Digit = Number % 10;

                Number = Number / 10;

                DigitSum += Digit;
            }

            Console.WriteLine(DigitSum);
        }
    }
}
