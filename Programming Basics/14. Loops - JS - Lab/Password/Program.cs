using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            string Pass = Console.ReadLine();
            string Imput = Console.ReadLine();

            while(Imput!=Pass)
            {
                Imput = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {Name}!");
        }
    }
}
