using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] Array = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();


            int[] Arra2 = Array;

            for (int i = 0; i < Array.Length-1; i++)
            {              
                    for (int j = 0; j < Array.Length - 1; j++)
                    {
                        Arra2[j] = Array[j] + Array[j + 1];
                    }

                    Arra2 = Array;

            }
            Console.WriteLine(Array[0]);

            Console.WriteLine(string.Join(" ",Array));

           










        }
    }
}
