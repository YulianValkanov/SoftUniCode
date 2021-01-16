using System;
using System.Collections.Generic;

namespace _4._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> Names = new List<string>();

            for (int i = 0; i < n; i++)
            {
               
                Names.Add(Console.ReadLine());
            }


            Names.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Names[i]);
            }
           
        }
    }
}
