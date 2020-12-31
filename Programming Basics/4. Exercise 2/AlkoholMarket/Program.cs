    using System;

    namespace AlkoholMarket
    {
        class Program
        {
            static void Main()
            {

                Double PriceWhisky = Double.Parse(Console.ReadLine());

                Double CountBeer = Double.Parse(Console.ReadLine());
                Double CountWine = Double.Parse(Console.ReadLine());
                Double CountRakiq = Double.Parse(Console.ReadLine());
                Double CountWhisky = Double.Parse(Console.ReadLine());

                Double PriceRakia = PriceWhisky * 0.5;
                Double PriceWine = PriceRakia * 0.6;
                Double PriceBeer = PriceRakia * 0.2;

                Double TotalWhusky = CountWhisky * PriceWhisky;
                Double TotalRakia = CountRakiq * PriceRakia;
                Double TotalWine = CountWine * PriceWine;
                Double TotalBeer = CountBeer * PriceBeer;

                Double FinalPrice = (TotalBeer + TotalRakia + TotalWhusky + TotalWine);

                Console.WriteLine($"{FinalPrice:f2}");
            }
        }
    }
