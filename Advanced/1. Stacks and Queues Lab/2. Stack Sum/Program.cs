using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stackNumbers = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stackNumbers.Push(numbers[i]);
            }

            string comandInput = Console.ReadLine().ToLower();

            
            while (comandInput!="end")
            {
                string[] comandArray = comandInput.Split(" ");
                string currComand = comandArray[0].ToLower();

                if (currComand=="add")
                {
                    int firstElement = int.Parse(comandArray[1]);
                    int secondElement = int.Parse(comandArray[2]);

                    stackNumbers.Push(firstElement);
                    stackNumbers.Push(secondElement);


                }
                else if (currComand=="remove")
                {
                    int elementsToRemove = int.Parse(comandArray[1]);

                    if (elementsToRemove>stackNumbers.Count)
                    {
                        
                    }
                    else
                    {
                        for (int i = 0; i < elementsToRemove; i++)
                        {
                            stackNumbers.Pop();
                        }
                    }

                   
                }

                comandInput = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stackNumbers.Sum()}");
        }
    }
}
