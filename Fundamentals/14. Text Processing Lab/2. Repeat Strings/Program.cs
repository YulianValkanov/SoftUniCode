using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            StringBuilder hi = new StringBuilder();

            foreach (var word in words)
            {
                int howBig = word.Length;
                for (int i = 0; i < howBig; i++)
                {
                    hi.Append(word);
                }
                
            }

            Console.WriteLine(hi);
        }
    }
}
