using System;

namespace _1._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Number(n);
        }

        static void Number(int n)
        {
           

            if (n>0)
            {
                Console.WriteLine($"The number { n} is positive.");
            }
            else if (n<0)
            {
                Console.WriteLine($"The number { n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number { n} is zero.");
            }
        }
    }
}
