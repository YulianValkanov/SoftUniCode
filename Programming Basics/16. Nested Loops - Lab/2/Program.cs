using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    Console.WriteLine($"{r} * {c} = {r*c}");
                }
            }



            
        }
    }
}
