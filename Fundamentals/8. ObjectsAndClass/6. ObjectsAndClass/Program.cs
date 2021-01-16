using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._ObjectsAndClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Words = Console.ReadLine().Split(" ");

            Random rnd = new Random();

            for (int pos1 = 0; pos1 < Words.Length; pos1++)
            {
                int pos2 = rnd.Next(Words.Length);

                string currentPos = Words[pos1];

                Words[pos1] = Words[pos2];
                Words[pos2] = currentPos;
            }

            Console.WriteLine(String.Join(Environment.NewLine,Words));
        }
    }
}
