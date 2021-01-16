using System;
using System.Linq;

namespace _2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Aray1 = Console.ReadLine().Split(" ");
            string[] Aray2 = Console.ReadLine().Split(" ");

            foreach (string ElementTwo in Aray2)
            {
                for (int i = 0; i <Aray1.Length; i++)
                {
                    if (ElementTwo==Aray1[i])
                    {
                        Console.Write($"{ ElementTwo} ");
                        break;
                    }
                }
            }
        }
    }
}
