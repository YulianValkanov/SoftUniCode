using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());

            int SecondNum = int.Parse(Console.ReadLine());

            int calculateFacturiel = GetFactorial(firstNum);

            int CalculateFacturiel2 = GetFactorial(SecondNum);
       
            double Result = calculateFacturiel / CalculateFacturiel2;

            Console.WriteLine($"{Result:f2}");

          
        }

        

        private static int GetFactorial(int firstNum)
        {
            int FirstNumFactoriel = 1;
            for (int i = firstNum; i > 0; i--)
            {
                FirstNumFactoriel *= i;
            }
            return FirstNumFactoriel;
        }
    }
}
