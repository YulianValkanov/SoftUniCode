using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {

            double Num = double.Parse(Console.ReadLine());

            double Quest = (Num % 2);

            if (Quest == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
