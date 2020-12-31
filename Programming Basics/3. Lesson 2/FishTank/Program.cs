using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {

            int Daljina = int.Parse(Console.ReadLine());
            int Shirina = int.Parse(Console.ReadLine());

            int Visochina = int.Parse(Console.ReadLine());

            Double Percent = double.Parse(Console.ReadLine());
            Double PrecentFinal = Percent / 100;

            int obem = Daljina * Shirina * Visochina;
            double Litri = obem * 0.001;

            double KrainiLitri = Litri * (1 - PrecentFinal);

            Console.WriteLine($"{KrainiLitri:f3}");
        }
    }
}
