using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            int Health = 100;

            int bitcoint = 0;

            string[] imput = Console.ReadLine().Split("|");

            for (int i = 0; i < imput.Length; i++)
            {
                string[] imput2 = imput[i].Split(" ");

                string comand = imput2[0];
                int point = int.Parse(imput2[1]);

                if (comand== "potion")
                {
                    if (Health + point > 100)
                    {
                        Health = 100;
                    }
                    else
                    {
                        Health += point;
                    }
                    Console.WriteLine($"You healed for {10} hp.");
                    Console.WriteLine($"Current health: {Health} hp.");
                }
                else if (comand== "chest")
                {
                    bitcoint += point;
                    Console.WriteLine($"You found {point} bitcoins.");
                }
                else
                {
                    Health -= point;
                    if (Health>0)
                    {
                        Console.WriteLine($"You slayed {comand}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {comand}.");
                        Console.WriteLine($"Best room: {i+1}");
                        break;
                    }
                }

       
            }
            if (Health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoint}");
                Console.WriteLine($"Health: {Health}");
            }


        }
    }
}
