using System;
namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());

            int Sum = 0;

                for (int i = 0; i < Num; i++)
            {
                int CurrNum = int.Parse(Console.ReadLine());
                Sum += CurrNum;
            }
            Console.WriteLine(Sum);
        }
    }
}
