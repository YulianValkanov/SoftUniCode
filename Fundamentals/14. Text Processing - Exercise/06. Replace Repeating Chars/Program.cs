using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string newString = string.Empty;

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i]!=input[i+1])
                {
                    newString += input[i];
                }
            }
            newString += input[input.Length-1];

            Console.WriteLine(newString);
        }
    }
}
