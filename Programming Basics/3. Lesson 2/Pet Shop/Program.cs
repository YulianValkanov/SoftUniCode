using System;

namespace Projents_Creations
{

    class Program
    {
        static void Main(string[] args)
        {
            int Dogs = int.Parse(Console.ReadLine());
            int Others = int.Parse(Console.ReadLine());

            double DogsPrise = Dogs * 2.5;
            int OtherPrise = Others * 4;
            double EndPrise = DogsPrise + OtherPrise;

            Console.WriteLine(EndPrise);
        }
    }
}
