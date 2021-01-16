using System;
using System.Linq;

namespace _4._Rotations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Array = Console.ReadLine()
                .Split(" ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string ElementToRorate = Array[0];
               

                for (int j = 1; j < Array.Length; j++)
                {
                    string CurreentElement = Array[j];
                    Array[j - 1] = CurreentElement;
                }
                Array[Array.Length - 1] = ElementToRorate;

            }

            Console.WriteLine(string.Join(" ",Array));

            
        }
    }
}
