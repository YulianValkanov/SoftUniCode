using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            int Power = int.Parse(Console.ReadLine());

            double Result = PowerdNumber(Number, Power);

            Console.WriteLine(Result);
        }

        private static double PowerdNumber(double number, int power)
        {
            double Result = number;

            for (int i = 0; i < power-1; i++)
            {
                Result = Result * number;

               
            }
            return Result;
        }
    }
}
