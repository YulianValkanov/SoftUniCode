using System;

namespace Lili
{
    class Program
    {
        static void Main(string[] args)
        {

            int Age = int.Parse(Console.ReadLine());
            double Peralnq = double.Parse(Console.ReadLine());
            double SinPrice = double.Parse(Console.ReadLine());

            double Savings = 0;
            double toys = 0;
            double Money = 10;

            for (int i = 1; i <= Age; i++)
            {
                if(i%2==0)
                {
                    Savings += Money-1;
                    Money += 10;
                }
                else
                {
                    toys++;
                }
               
            }
            Savings += toys * SinPrice;
            double Diff = Math.Abs(Peralnq - Savings);

            if(Savings>=Peralnq)
            {
                Console.WriteLine($"Yes! {Diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Diff:f2}");
            }
        }
    }
}
