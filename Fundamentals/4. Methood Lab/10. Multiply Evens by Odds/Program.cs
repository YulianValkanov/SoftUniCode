using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());

            string NumString = Num.ToString();

            int CountEven = 0;

            int CountOdd = 0;

            for (int i = 0; i < NumString.Length; i++)
            {
                char Digit = NumString[i];

                int DigitInteger = int.Parse(Digit.ToString());
                   
                

                if (DigitInteger%2==0)
                {
                    CountEven+=DigitInteger;
                }
                else
                {
                    CountOdd += DigitInteger;
                }
            }

            Console.WriteLine(CountOdd*CountEven);


        }
    }
}
