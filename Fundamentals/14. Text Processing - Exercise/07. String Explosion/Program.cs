using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

           

            int currentBomb = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '>')
                {
                    
                    currentBomb += int.Parse(input[i+1].ToString());

                    
                    continue;

                }

                if (currentBomb>0)
                {
                    input=input.Remove(i, 1);
                    i--;
                    currentBomb--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
