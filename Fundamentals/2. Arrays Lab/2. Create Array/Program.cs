using System;

namespace _2._Create_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int r = 0; r < length; r++)
            {
                Console.WriteLine(arr[r]);
            }
        }
    }
}
