using System;

namespace Trailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {

            int TablesNum = int.Parse(Console.ReadLine());
            double TablesDaljina = double.Parse(Console.ReadLine());
            double TablesShirina = Double.Parse(Console.ReadLine());

            double ProshtPokrivki = TablesNum * (TablesDaljina+2*0.3) * (TablesShirina+2*0.3);
            double PloshtKareta = TablesNum*(TablesDaljina / 2)* (TablesDaljina / 2);

            double PriseUSD = ProshtPokrivki * 7 + PloshtKareta * 9;

            double PriseBGN = PriseUSD * 1.85;

            Console.WriteLine($"{PriseUSD:f2} USD");
            Console.WriteLine($"{PriseBGN:f2} BGN");

        }
    }
}
