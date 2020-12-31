using System;

namespace Godzilla
{
    class Program
    {
        static void Main(string[] args)
        {
            double Budjet = double.Parse(Console.ReadLine());
            int CountStatist = int.Parse(Console.ReadLine());
            double PriceClotes = double.Parse(Console.ReadLine());
            double FinalClotes = PriceClotes * CountStatist;

            double Dekor = 0.1 * Budjet;
            if (CountStatist>150)
            {
                FinalClotes = FinalClotes* 0.9;
            }

            double FinalCosts = FinalClotes + Dekor;

            if (FinalClotes>Budjet)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(FinalCosts - Budjet):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(Budjet-FinalCosts):f2} leva left.");
            }
            
        }
    }
}
