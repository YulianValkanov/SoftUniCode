using System;

namespace Projents_Creations
{
    class Program
    {
        static void Main(string[] args)
        {

            string Name = Console.ReadLine();

            int Projects = int.Parse(Console.ReadLine());

            int Time = Projects * 3;
            Console.WriteLine($"The architect {Name} will need {Time} hours to complete {Projects} project/s.");
        }
    }
}
