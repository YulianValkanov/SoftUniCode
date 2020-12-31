using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            

            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                int Budjet = int.Parse(Console.ReadLine());

                while (Budjet>0)
                {
                   int Money= int.Parse(Console.ReadLine());
                    Budjet -= Money;
                }
                Console.WriteLine($"Going to {destination}!");
            }
            
        }
    }
}
