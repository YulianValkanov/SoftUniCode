using System;
using System.Linq;

namespace _6._EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine()
              .Split(" ")
              .Select(int.Parse)
              .ToArray();

            bool isFound = false;

            for (int curr = 0; curr < Arr.Length; curr++)
            {
                int sumRight = 0;

                for (int i = curr+1; i < Arr.Length; i++)
                {
                    sumRight += Arr[i];
                }

                int sumLeft = 0;

                for (int i = curr-1; i >= 0; i--)
                {
                    sumLeft += Arr[i];
                }

                if (sumRight==sumLeft)
                {
                    Console.WriteLine(curr);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
