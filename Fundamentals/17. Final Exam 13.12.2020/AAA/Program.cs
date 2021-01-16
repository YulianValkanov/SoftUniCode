using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // person name : health : energy
            Dictionary<string, List<int>> people = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "Results")
            {
                string[] inputArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string comands = inputArgs[0];

                if (comands == "Add")
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
                else if (comands == "Attack")
                {
                    string atackerName = inputArgs[1];
                    string defenderName = inputArgs[2];
                    int damage = int.Parse(inputArgs[3]);
                    if (people.ContainsKey(atackerName)&&people.ContainsKey(defenderName))
                    {
                        people[defenderName][0] -= damage;
                        people[atackerName][1] -= 1;

                        if (people[defenderName][0]<=0)
                        {
                            Console.WriteLine($"{defenderName} was disqualified!");
                            people.Remove(defenderName);
                        }
                        if (people[atackerName][1]<=0)
                        {
                            Console.WriteLine($"{atackerName} was disqualified!");
                            people.Remove(atackerName);
                        }
                    }

                }
                else if (comands == "Delete")
                {
                    string userName = inputArgs[1];

                    if (userName=="All")
                    {
                        people.Clear();
                    }
                    else
                    {
                        people.Remove(userName);
                    }
                    
                }



                input = Console.ReadLine();
            }
            Console.WriteLine($"People count: {people.Count}");
            foreach (var item in people.OrderByDescending(x=>x.Value[0]).ThenBy(a=>a.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");
            }
        }
    }
}
