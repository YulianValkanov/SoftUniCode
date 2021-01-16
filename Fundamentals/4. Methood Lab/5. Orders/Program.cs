using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string Kind = Console.ReadLine();
            double Quantity = int.Parse(Console.ReadLine());

            TotalPrice(Kind, Quantity);
        }

        private static void TotalPrice(string kind, double quantity)
        {

            double PricEcoffee = 1.50;
            double PricEwoter = 1.00;
            double PricEcoce = 1.40;
            double PricEsnaks = 2.00;

       
            double Result = 0;

            switch (kind)
            {
                case "coke":
                    Result = PricEcoce * quantity;
                    break;
                case "coffee":
                    Result = PricEcoffee * quantity;
                    break;
                case "water":
                    Result = PricEwoter * quantity;
                    break;
                case "snacks":
                    Result = PricEsnaks * quantity;
                    break;
            }
            Console.WriteLine($"{Result:f2}");
        }
    }
}
