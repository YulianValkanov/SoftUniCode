using System;
using System.Text.RegularExpressions;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\S+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1";

            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();


                Match match = regex.Match(currentString);

                if (match.Success)
                {

                    Console.WriteLine($"Password: {match.Groups[2].Value+ match.Groups[3].Value+ match.Groups[4].Value+ match.Groups[5].Value}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
