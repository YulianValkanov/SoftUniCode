using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {

            int Dogs = int.Parse(Console.ReadLine());
            int Others = int.Parse(Console.ReadLine());
            Double DogsPrise = Dogs * 2.5;
            Double OtherPrise = Others * 4;
            Double FinalPrise = DogsPrise + OtherPrise;

            Console.WriteLine($"{FinalPrise:f2} lv.");
        }
    }
}
