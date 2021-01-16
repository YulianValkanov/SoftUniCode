using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();

            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();



            while (imput!="end")
            {
                List<string> comands = imput.Split(" : ").ToList();

                string course = comands[0];
                string name = comands[1];

                if (!results.ContainsKey(course))
                {
                    results.Add(course, new List <string>());


                }
                results[course].Add(name);

                imput = Console.ReadLine();
            }

            foreach (var courese in results.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{courese.Key}: {courese.Value.Count}");

                foreach (var item in courese.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
