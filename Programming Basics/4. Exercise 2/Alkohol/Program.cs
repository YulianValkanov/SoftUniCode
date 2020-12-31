using System;

namespace Alkohol
{
    class Program
    {
        static void Main(string[] args)
        {

            double PriceWhisky = double.Parse(Console.ReadLine());
            double CountBeer = double.Parse(Console.ReadLine());
            double CountWine = double.Parse(Console.ReadLine());
            double CountRakia = double.Parse(Console.ReadLine());
            double CountWhisky = double.Parse(Console.ReadLine());

            double PriceRakia = PriceWhisky * 0.5;
            double PriceWine = PriceRakia * 0.6;
            double PriceBeer = PriceRakia * 0.2;

            Double FinalPrice = CountBeer * PriceBeer + CountWine * PriceWine + CountWhisky * PriceWhisky + CountRakia * PriceRakia;

            Console.WriteLine($"{FinalPrice:f2}");
        }
    }
}
