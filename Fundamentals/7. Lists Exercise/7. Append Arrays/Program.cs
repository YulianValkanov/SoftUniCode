using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

          

            List<string> NEW = new List<string>();

            for (int i = 0; i < array.Count; i++)
            {


                List<string> CurrentList = array[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

                

                for (int j = 0; j < CurrentList.Count; j++)
                {
                    NEW.Add(CurrentList[j]);
                }
               
            }

            Console.WriteLine(String.Join(" ",NEW));
            
        }
    }
}
