using System;
using System.Linq;

namespace _2.MoreExerciseArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            bool isOK = false;

            for (int i = 0; i < Array.Length; i++)
            { 
                int LeftSum = 0;
                int RightSum = 0;

                for (int Right = i+1; Right < Array.Length; Right++)
                {
                    RightSum += Array[Right];
                }

                for (int Left = i-1; Left >= 0; Left--)
                {
                    LeftSum += Array[Left];
                }

                if (LeftSum==RightSum)
                {
                    Console.WriteLine(i);
                    isOK = true;
                    break;
                }
                
            }
            if (isOK==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
