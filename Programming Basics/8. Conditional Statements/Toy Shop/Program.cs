using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            double PriseEx = double.Parse(Console.ReadLine());
            double CountPuzzel = double.Parse(Console.ReadLine());
            double CountBarby = double.Parse(Console.ReadLine());
            double CountBeer = double.Parse(Console.ReadLine());
            double CountMinnion = double.Parse(Console.ReadLine());
            double CountTrack = double.Parse(Console.ReadLine());

            double Bill = CountPuzzel * 2.6 + CountBarby * 3 + CountBeer * 4.1 + CountMinnion * 8.2 + CountTrack * 2;

            double Count = CountBarby + CountBeer + CountMinnion + CountPuzzel + CountTrack;

            double PriceDiscount = (Bill * 0.75 * 0.9);

            Double PriceWihoutDis = (Bill * 0.9);

            if (Count >= 50)
            {
                double Revenue = (PriceDiscount - PriseEx);
                if (Revenue >= 0)
                {
                    Console.WriteLine($"Yes! {Revenue:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Revenue*-1:f2} lv needed.");
                }
            }
            else
            {
                double Revenue = PriceWihoutDis-PriseEx;
                if (Revenue>=0)

                {
                    Console.WriteLine($"Yes! {Revenue:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Revenue*-1:f2} lv needed.");
                }
            }




        }
    }
}
