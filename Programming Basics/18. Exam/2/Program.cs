using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Intelectual = int.Parse(Console.ReadLine());
            int Power = int.Parse(Console.ReadLine());
            string Male = Console.ReadLine();

            if(Intelectual>=80&&Power>=80&&Male== "female")
            {
                Console.WriteLine("Queen Bee");
            }
            else if(Intelectual>=80)
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (Intelectual >= 60)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if (Power >= 80&&Male=="male")
            {
                Console.WriteLine("Drone Bee");
            }
            else if (Power >= 60)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }
            


        }
    }
}
