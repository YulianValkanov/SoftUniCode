using System;

namespace Cncatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {

            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            int Age = int.Parse (Console.ReadLine());
            string City = Console.ReadLine();

            Console.WriteLine($"You are {FirstName} {LastName}, a {Age}-years old person from {City}.");
        }
    }
}