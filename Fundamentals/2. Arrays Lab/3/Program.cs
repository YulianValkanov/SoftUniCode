using System;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string[] textArr = line.Split(", ",StringSplitOptions.RemoveEmptyEntries);

            int[] arr = textArr.Select(int.Parse).ToArray();


            for (int i = 0; i < textArr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
