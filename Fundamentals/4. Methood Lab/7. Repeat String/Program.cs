using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            NewString(Word, n);
        }

        private static void NewString(string word, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(word);
            }
        }
    }
}
