using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Associatate_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();

            string sintizatorString = imput.Replace(" ", string.Empty);

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < sintizatorString.Length; i++)
            {
                char currentChar = sintizatorString[i];

                if (dictionary.ContainsKey(currentChar))
                {
                    dictionary[currentChar]++;

                }
                else
                {
                    dictionary.Add(currentChar, 1);
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
