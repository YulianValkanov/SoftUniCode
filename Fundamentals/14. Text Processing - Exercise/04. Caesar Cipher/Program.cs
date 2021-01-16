using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string newString = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int currentInt = (int)input[i]+3;

                newString += (char)currentInt;
            }

            Console.WriteLine(newString);
        }
    }
}
