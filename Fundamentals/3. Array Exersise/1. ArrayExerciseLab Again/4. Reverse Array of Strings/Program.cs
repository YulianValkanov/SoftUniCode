using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Array = Console.ReadLine().Split(" ");

            Console.Write(string.Join(" ", Array.Reverse()));
        }

       
    }
}
