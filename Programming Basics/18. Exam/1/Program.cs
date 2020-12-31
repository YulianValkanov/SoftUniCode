using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountBee = int.Parse(Console.ReadLine());
            int CountFlowers = int.Parse(Console.ReadLine());

            double Med = CountBee * CountFlowers * 0.21;
            double Piti = Math.Floor(Med / 100);
            double Ostatak = Med - Piti*100;

            Console.WriteLine($"{Piti} honeycombs filled.");
            Console.WriteLine($"{Ostatak:f2} grams of honey left.");
        }
    }
}
