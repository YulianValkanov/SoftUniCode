using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            Dictionary<string, int> resourses = new Dictionary<string, int>();

            while (comand!="stop")
            {
                int valueResourses = int.Parse(Console.ReadLine());

                if (resourses.ContainsKey(comand))
                {
                    resourses[comand] += valueResourses;
                }
                else
                {
                    resourses.Add(comand, valueResourses);
                }




                comand = Console.ReadLine();

            }
            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
