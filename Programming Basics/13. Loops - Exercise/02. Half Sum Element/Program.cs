using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Sum = 0;
            int MaxNum = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int Numbers = int.Parse(Console.ReadLine());
                Sum += Numbers;
                if (MaxNum < Numbers)
                {
                    MaxNum = Numbers;
                }
            }
            int SumWithoutMax = Sum - MaxNum;
           if(SumWithoutMax==MaxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {MaxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+ Math.Abs(SumWithoutMax-MaxNum));
            }
        }
    }
}
