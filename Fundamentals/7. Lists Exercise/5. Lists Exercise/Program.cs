using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Lists_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] CurrentText = Console.ReadLine().Split(" ").ToArray();

                if (CurrentText[0] == "end")
                {
                    Console.WriteLine(String.Join(" ",Wagons));
                    break;
                }
                else
                {
                    if (CurrentText[0] == "Add")
                    {
                        Wagons.Add(int.Parse(CurrentText[1]));
                    }
                    else
                    {
                        for (int i = 0; i < Wagons.Count; i++)
                        {
                            if (capacity>=(Wagons[i]+int.Parse(CurrentText[0])))
                            {
                                Wagons[i] = Wagons[i] + int.Parse(CurrentText[0]);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
