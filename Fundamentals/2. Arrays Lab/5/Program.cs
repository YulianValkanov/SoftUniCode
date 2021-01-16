using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] Num = new int[n];

            for (int i = 0; i < n; i++)
            {
                Num[i] = int.Parse(Console.ReadLine());
            }

            for (int r = n-1; r >= 0; r--)
            {
                Console.Write("{0} ",Num[r]);
            }

            // console.writeLine(string.Join(" ",arr.Reverse()));
        }
    }
}
