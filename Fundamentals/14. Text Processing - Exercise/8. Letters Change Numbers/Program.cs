using System;
using System.Linq;

namespace _8._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
           

            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            int how = input.Length;

            double result = 0;

            for (int i = 0; i < how; i++)
            {
                result += compresor(input[i]);
            }

           

            Console.WriteLine($"{result:f2}");
        }

        private static double compresor(string firstWord)
        {
            char firstAlfabet = firstWord[0];
            char lastAlfabet = firstWord[firstWord.Length - 1];
            string number = string.Empty;
            for (int i = 1; i < firstWord.Length - 1; i++)
            {
                number += firstWord[i];
            }


            double intNumber = double.Parse(number);

            double firstNumber = 0;
            if (char.IsUpper(firstAlfabet))
            {
                firstNumber = (double)firstAlfabet - 64;
                intNumber = intNumber / firstNumber;
            }
            else
            {
                firstNumber = (double)firstAlfabet - 96;
                intNumber = intNumber * firstNumber;
            }

            double lastNumber = 0;
            if (char.IsUpper(lastAlfabet))
            {
                lastNumber = (double)lastAlfabet - 64;
                intNumber = intNumber - lastNumber;
            }
            else
            {
                lastNumber = (double)lastAlfabet - 96;
                intNumber = intNumber + lastNumber;
            }

           

            return (intNumber);
        }
    }
}
