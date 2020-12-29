using System;
using System.Collections.Generic;

namespace _3._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // person name : health : energy
            Dictionary<string, List<int>> people = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input!="Results")
            {
                string[] inputArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string comands = inputArgs[0];

                if (comands=="Add")
                {
                    string personName = inputArgs[1];
                    int health = int.Parse(inputArgs[2]);
                    int energy = int.Parse(inputArgs[3]);
                    List<int> healthEnergy = new List<int> { health, energy };

                    if (people.ContainsKey(personName))
                    {
                        people[personName][0] += health;
                    }
                    else
                    {
                        people.Add(personName, healthEnergy);
                    }
                   
                }
                else if (comands=="Attack")
                {
                    string atackerName = inputArgs[1];
                    string defenderName = inputArgs[2];
                    int damage = int.Parse(inputArgs[3]);
                }
                else if (comands=="Delete")
                {
                    string userName = inputArgs[1];
                }



                input = Console.ReadLine();
            }
        }
    }
}
