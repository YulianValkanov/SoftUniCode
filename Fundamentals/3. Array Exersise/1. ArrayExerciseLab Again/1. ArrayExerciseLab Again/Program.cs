using System;

namespace _1._ArrayExerciseLab_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Array = { "Monday", "Thusday", "Thirstday", "Whednesday", "Friday", " Saturday", "Sunday" };

            int n = int.Parse(Console.ReadLine());

            if (n > 7 || n < 1)
            {
                Console.WriteLine("Invalide Date!");
            }
            else
            {
                Console.WriteLine(Array[n - 1]);
            }
        }
    }
}
