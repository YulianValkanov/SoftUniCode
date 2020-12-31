using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Count = 0;
            int MinValue = int.MaxValue;

            while(n>Count)
            {
                int Num = int.Parse(Console.ReadLine());
                if (MinValue>Num)
                {
                    MinValue = Num;
                }
                Count++;
            }


            Console.WriteLine(MinValue);
        }
    }
}
