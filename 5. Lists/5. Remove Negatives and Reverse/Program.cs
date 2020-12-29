using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i]<0)
                {
                    Numbers.RemoveAt(i--);
                }
            }

            Numbers.Reverse();

            if (Numbers.Count==0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", Numbers));
            }

           // List<int> Result =Numbers.Where(n=> n>=0).Reverse().ToList();
        }
    }
}
