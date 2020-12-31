using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {

            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double PloshtZala = L * W;
            double PloshtGarderob = A * A;
            Double PloshtSkameika = PloshtZala / 10;
            Double PloshtOstatak = PloshtZala - PloshtGarderob - PloshtSkameika;

            Double SpaceHuman = 7040.00/10000.00;

            Double CountHuman = PloshtOstatak / SpaceHuman;

            Console.WriteLine(Math.Floor(CountHuman));
        }
    }
}
