using System;
using System.Linq;


namespace _5._TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            bool IsBiggel = true;

            for (int i = 0; i < Arr.Length; i++)
            {
                int CurrentElement = Arr[i];

                for (int j = i+1; j < Arr.Length; j++)
                {
                    if (Arr[j]>=CurrentElement)
                    {
                        IsBiggel = false;
                        break;
                    }
                    
                }
                if (IsBiggel==true)
                {
                    Console.Write(CurrentElement + " ");
                }

                IsBiggel = true;
            }
        }
    }
}
