using System;
using System.Linq;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeWord = Console.ReadLine().ToLower();

            string word = Console.ReadLine().ToLower();

            int index = word.IndexOf(removeWord);

            int Long = removeWord.Length;

            while (index!=-1)
            {
                word = word.Remove(index, Long);

                index= word.IndexOf(removeWord); 
            }

            Console.WriteLine(word);
        }
    }
}
