using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Array = Console.ReadLine()
                .Split(" ");

            int bestCount = 0;
            int BestIndex = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                string CurrentElement = Array[i];

                int CurrentCounter = 1;

                for (int j = i+1; j < Array.Length; j++)
                {
                    
                        if (CurrentElement==Array[j])
                        {
                        CurrentCounter++;
                        }
                    else
                    {
                        break;
                    }
                }
                if (CurrentCounter>bestCount)
                {
                    bestCount = CurrentCounter;
                    BestIndex = i;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(Array[BestIndex]+" ");
            }
        }
    }
}
