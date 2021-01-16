using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] a = text.ToCharArray();



            string intT = string.Empty;
            string strR = string.Empty;
            string charR = string.Empty;

            for (int i = 0; i < a.Length; i++)
            {
                char currentDigit = a[i];

                if (currentDigit>='0'&& currentDigit<='9')
                {
                    intT += currentDigit;
                }
                else if ((currentDigit >= 'a' && currentDigit <= 'z')|| (currentDigit >= 'A' && currentDigit <= 'Z'))
                {
                    strR += currentDigit;
                }
                else
                {
                    charR += currentDigit;
                }
            }

            Console.WriteLine(intT);
            Console.WriteLine(strR);
            Console.WriteLine(charR);
        }
           
    }
}
