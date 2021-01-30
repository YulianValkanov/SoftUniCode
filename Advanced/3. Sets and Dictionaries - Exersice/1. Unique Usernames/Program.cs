using System;
using System.Collections.Generic;

namespace _6._Sets_and_Dictionaries___Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> name = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();


                name.Add(names);
            }

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
