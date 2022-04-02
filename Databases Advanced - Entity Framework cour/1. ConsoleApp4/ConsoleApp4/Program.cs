using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string first=Console.ReadLine();

            while (first!="stop")
            {
                if (first == "Hi")
                {
                    Console.WriteLine("Yeas");
                }
                else
                {
                    Console.WriteLine("no");
                }

                 first = Console.ReadLine();
            }
           
        }
    }
}
