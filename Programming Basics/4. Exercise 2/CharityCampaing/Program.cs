using System;

namespace CharityCampaing
{
    class Program
    {
        static void Main(string[] args)
        {

            int CountDays = int.Parse(Console.ReadLine());
            int CountChefs = int.Parse(Console.ReadLine());

            int CountCaces = int.Parse(Console.ReadLine());

            int CountGofreta = int.Parse(Console.ReadLine());

            int CountPuncace = int.Parse(Console.ReadLine());

            int PriseCaces = 45 * CountCaces;
            double PriseGofreta = 5.80 * CountGofreta;
            Double PrisePuncace = 3.20 * CountPuncace;

            double TotalPrise = CountDays * CountChefs * (PriseCaces + PriseGofreta + PrisePuncace);

            Double FilanPrise = TotalPrise * 7 / 8;

            Console.WriteLine($"{FilanPrise:f2}");



        }
    }
}
