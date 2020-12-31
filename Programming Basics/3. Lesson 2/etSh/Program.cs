using System;

namespace etSh
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dogs = int.Parse(Console.ReadLine());
            int Others = int.Parse(Console.ReadLine());

            double DogsPrise = Dogs * 2.5;
            double OtherPrise = Others * 4;

            Double newPrise = DogsPrise + OtherPrise;

            Console.WriteLine($"{newPrise:f2} lv.");

            Console.WriteLine(Math.Round(newPrise, 0));
        }
    }
}
