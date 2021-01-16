using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();

            List<string> users = input.Split(", ").ToList();

            for (int i = 0; i < users.Count; i++)
            {
                string currentUser = users[i];

                if (isValid(currentUser))
                {
                    Console.WriteLine(currentUser);
                }

            }


        }

        private static bool isValid(string currents)
        {
            return (currents.Length >= 3 && 
                currents.Length <= 16) && 
                currents.All(c => char.IsLetterOrDigit(c)) ||
                   currents.Contains("-") || currents.Contains("_");
        }
    }
}
