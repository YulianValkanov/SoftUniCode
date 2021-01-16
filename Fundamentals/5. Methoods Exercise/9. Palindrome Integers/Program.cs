using System;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            string Num = string.Empty;

            Validator(Num);

            

             
        }

        private static void Validator(string Num)
        {
            while (true)
            {
                Num = Console.ReadLine();

                if (Num == "END")
                {
                    break;
                }

                char FirstNum = Num[0];

                char LastNum = Num[Num.Length - 1];

                if (FirstNum == LastNum)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
