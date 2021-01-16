using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int TopNum = int.Parse(Console.ReadLine());

            Digits(TopNum);


        }

        private static void Digits(int TopNum)
        {
            for (int i = 1; i <= TopNum; i++)
            {
                string CurrentNumber = i.ToString();

                int sumOfDigits = 0;

                int CountOdd = 0;

                for (int j = 0; j < CurrentNumber.Length; j++)
                {
                    char CurrentDigit = CurrentNumber[j];

                    int CurrentDigitInteger = int.Parse(CurrentDigit.ToString());

                    //even
                    if (CurrentDigitInteger % 2 == 0)
                    {

                    }
                    //odd
                    else
                    {
                        CountOdd++;
                    }

                    sumOfDigits += CurrentDigitInteger;
                }

                if (sumOfDigits % 8 == 0 && CountOdd > 0)
                {
                    Console.WriteLine(CurrentNumber);
                }
            }
        }
    }
}
