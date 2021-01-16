using System;
using System.Linq;

namespace Print_Numbers_in_Revere_Orded
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] Array = new int[n];

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ",Array.Reverse()));
            
        }
    }
}
