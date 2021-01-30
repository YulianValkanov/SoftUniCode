using System;
using System.Collections.Generic;

namespace _10.List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> chips = new Dictionary<int, string>();

            int Apartments = 10;

            for (int i = 1; i <= Apartments; i++)
            {
                chips.Add(i, "on");
            }

            chips[5] = "off";
            chips[6] = "on";

            foreach (var item in chips)
            {
                Console.WriteLine("Chip № "+ item.Key + " статус: "+ item.Value);
            }


            foreach (var item in chips)
            {
                if (item.Value=="off")
                {
                    Console.WriteLine($"Apartment № {item.Key} is block! You have to pay taxes to unblock!");
                }
            }
        }
    }
}
