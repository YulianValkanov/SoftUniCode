using System;

namespace _6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            //even
            if (imput.Length%2==0)
            {
                string output = GetMidleCharForEvenStringLengh(imput);
                Console.WriteLine(output);
            }
            //odd
            else
            {
                string oddOutput = getMidleCharformOd(imput);
                Console.WriteLine(oddOutput);
            }

            
        }

        private static string getMidleCharformOd(string imput)
        {
            int index = imput.Length / 2;
            string chars = imput.Substring(index, 1);
            return chars;
        }

        private static string GetMidleCharForEvenStringLengh(string imput)
        {
            int index = imput.Length / 2;
            string chars = imput.Substring(index-1, 2);
            return chars;
        }
    }
}
