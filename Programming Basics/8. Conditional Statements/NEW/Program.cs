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

            double Revenue = 0;
            Revenue += CountPuzzel * 2.6;
            Revenue += CountBarby * 3;
            Revenue += CountBeer * 4.1;
            Revenue += CountMinnion * 8.2;
            Revenue += CountTrack * 2;

            double Count = CountPuzzel + CountBarby + CountBeer + CountMinnion + CountTrack;

            if (Count >= 50)
            {
                double Bill = Revenue * 0.75 * 0.9 - PriseEx;

                if (Bill >= 0)
                {
                    Console.WriteLine($"Yes! {Bill:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Bill * -1:f2} lv needed.");
                }
            }
            else
            {
                double Bill = Revenue * 0.9 - PriseEx;
                if (Bill >= 0)
                {
                    Console.WriteLine($"Yes! {Bill:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Bill * -1:f2} lv needed.");
                }
            }



        }
    }
}
