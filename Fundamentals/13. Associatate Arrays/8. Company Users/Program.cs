using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();

            SortedDictionary<string, List<string>> people = new SortedDictionary<string, List<string>>();

            while (imput!="End")
            {
                string[] comands = imput.Split(" -> ");

                string company = comands[0];
                string employ = comands[1];

                if (!people.ContainsKey(company))
                {
                    people.Add(company, new List<string>());

                    if (!people[company].Contains(employ))
                    {
                        people[company].Add(employ);
                    }
                }
                else
                {
                    if (!people[company].Contains(employ))
                    {
                        people[company].Add(employ);

                    }
                              
                           
                    
                     
                }

                imput = Console.ReadLine();

            }

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var what in item.Value)
                {
                    Console.WriteLine($"-- {what}");
                }

            }
        }
    }
}
