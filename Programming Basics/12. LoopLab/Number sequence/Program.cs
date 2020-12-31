using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            int bigest = int.MinValue;

            for (int i = 0; i < Num; i++)
            {
                int N = int.Parse(Console.ReadLine());
                if(N<smallest)
                {
                    smallest = N;
                }
                if (N > bigest)
                {
                    bigest = N;
                }
            }
            Console.WriteLine($"Max number: {bigest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
