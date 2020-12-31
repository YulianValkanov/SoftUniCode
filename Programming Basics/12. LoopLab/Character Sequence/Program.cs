using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();

            for (int i = 0; i < A.Length; i++)
            {
                char letter = A[i];

                Console.WriteLine(letter);
            }
           
        }
    }
}
