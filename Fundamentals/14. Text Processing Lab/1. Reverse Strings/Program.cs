using System;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input!="end")
            {

                string word = input;

                char[] arreyYord = word.ToCharArray();

                Console.WriteLine($"{word } = {string.Join("", arreyYord.Reverse())}");

                input = Console.ReadLine();
            }

        }   
    }
}
