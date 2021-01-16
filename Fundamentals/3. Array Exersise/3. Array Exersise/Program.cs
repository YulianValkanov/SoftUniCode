using System;
using System.Linq;

namespace _3._Array_Exersise
{
    class Program

    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];

            int Sum = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                Sum += wagons[i];
            }

            Console.WriteLine(String.Join(" ",wagons));
            Console.WriteLine(  Sum);
           

           
        }
    }
}
