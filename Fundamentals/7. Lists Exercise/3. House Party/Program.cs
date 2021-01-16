using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> Array = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> names = Console.ReadLine().Split(" ").ToList();
                if (names[2]=="not")
                {
                    if (Array.Contains(names[0]))
                    {
                        Array.Remove(names[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{names[0]} is not in the list!");
                    }
                   
                }
                else
                {

                    if (Array.Contains(names[0]))
                    {
                        Console.WriteLine($"{names[0]} is already in the list!");
                    }
                    else
                    {
                        Array.Add(names[0]);
                    }
                   
                }
     
            }
            for (int i = 0; i < Array.Count; i++)
            {
                Console.WriteLine(Array[i]);
            }
            
        }
    }
}
