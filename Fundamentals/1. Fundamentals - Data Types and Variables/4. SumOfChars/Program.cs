using System;

namespace _4._SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int Sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char Imput = char.Parse(Console.ReadLine());

                Sum += Imput;

               
            }

            Console.WriteLine($"The sum equals: {Sum}");
        }
    }
}
