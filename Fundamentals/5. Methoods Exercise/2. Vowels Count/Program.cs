using System;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string Imput = Console.ReadLine().ToLower();

            int Result = PritVowols(Imput);

            Console.WriteLine(Result);
        }

        public static int PritVowols(string Imput)
        {

            int counter = 0;

            for (int i = 0; i < Imput.Length; i++)
            {
                char CurrentChar = Imput[i];

                if (CurrentChar == 'a')
                {
                    counter++;
                }
                else if (CurrentChar == 'e')
                {
                    counter++;
                }
                else if (CurrentChar == 'i')
                {
                    counter++;
                }
                else if (CurrentChar == 'o')
                {
                    counter++;
                }
                else if (CurrentChar == 'u')
                {
                    counter++;
                }
                else if (CurrentChar == 'y')
                {
                    counter++;
                }
               
            }
            return counter;


        }
    }
}
