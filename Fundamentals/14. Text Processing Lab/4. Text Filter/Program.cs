using System;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] replacedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            for (int i = 0; i < replacedWords.Length; i++)
            {
                int londWord = replacedWords[i].Length;
                string currentReplace = string.Empty;
                for (int j = 0; j < londWord; j++)
                {
                    currentReplace += "*";
                }

                text = text.Replace(replacedWords[i], currentReplace);
               
            }
            Console.WriteLine(text);
        }
    }
}
