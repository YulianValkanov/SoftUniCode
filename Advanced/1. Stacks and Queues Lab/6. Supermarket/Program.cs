using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();

            Queue<string> peopleInShop = new Queue<string>();

            

            while (Input!="End")
            {
                if (Input=="Paid")
                {
                    int count = peopleInShop.Count;

                    for (int i = 0; i <count; i++)
                    {
                        Console.WriteLine(peopleInShop.Dequeue());
                    }
                }
                else
                {
                    peopleInShop.Enqueue(Input);
                }



                Input = Console.ReadLine();
            }

            Console.WriteLine($"{peopleInShop.Count} people remaining.");
        }
    }
}
