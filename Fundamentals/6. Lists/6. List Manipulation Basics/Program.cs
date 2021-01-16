using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool isFinish = false;

            while (!isFinish)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (input[0]=="end")
                {
                    Console.WriteLine(String.Join(" ",Numbers));
                    isFinish = true;
                }
                else if (input[0]== "Add")
                {
                    Numbers.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    Numbers.Remove(int.Parse(input[1]));
                }
                else if (input[0] == "RemoveAt")
                {
                    Numbers.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    Numbers.Insert(int.Parse(input[2]),int.Parse(input[1]));
                }
            }
        }
    }
}
