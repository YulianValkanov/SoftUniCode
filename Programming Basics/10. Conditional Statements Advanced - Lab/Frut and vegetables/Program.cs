using System;

namespace Frut_and_vegetables
{
    class Program
    {
        static void Main(string[] args)
        {

            string Kind = Console.ReadLine();

            switch(Kind)
            {
                case ("banana"):
                case ("apple"):
                case ("kiwi"):
                case ("cherry"):
                case ("lemon"):
                case ("grapes"):
                    Console.WriteLine("fruit");
                    break;
                case ("tomato"):
                case ("pepper"):
                case ("carrot"):
                case ("cucumber"):

                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
           
        }
    }
}
