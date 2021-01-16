using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Printing_Triangle(n);
        }

        private static void Printing_Triangle(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int r = 1; r <= i; r++)
                {
                    Console.Write(r+" ");                   
                }
                Console.WriteLine();
            }

            for (int i = 1; i < n; i++)
            {
                for (int r = 1; r <= n-i; r++)
                {
                    Console.Write(r+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
