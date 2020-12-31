using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            int First = int.Parse(Console.ReadLine());
            int Second = int.Parse(Console.ReadLine());
            for (int i = First; i <= Second; i++)
            {
                string currentNum = i.ToString();
                int oDDSum = 0;
                int evenSum = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDijut = int.Parse(currentNum[j].ToString());
                    if(j%2==0)
                    {
                        evenSum += currentDijut;
                    }
                    else
                    {
                        oDDSum += currentDijut; 
                    }
                }
                if(oDDSum==evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
