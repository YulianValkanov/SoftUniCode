using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Change_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string Comand = Console.ReadLine();

            while (Comand!="end")
            {
                string[] comandArg = Comand.Split(" ");

                if (comandArg[0]== "Delete")
                {
                    Wagons.RemoveAll((n=> n==int.Parse(comandArg[1])));
                }
                else if (comandArg[0] == "Insert")
                {
                    Wagons.Insert(int.Parse(comandArg[2]),int.Parse(comandArg[1]));
                }


                Comand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",Wagons));
        }
    }
}
