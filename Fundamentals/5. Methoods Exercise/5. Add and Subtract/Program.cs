using System;

namespace _5._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirthNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondNum, thirthNum);

            Console.WriteLine(sum);
        }

        private static int Sum(int firstNum, int secondNum, int thirthNum)
        {
            int SumFirstSecond = firstNum + secondNum;

            return Subtract(SumFirstSecond, thirthNum);
        }

        private static int Subtract(int sumFirstSecond, int thirthNum)
        {
            return sumFirstSecond - thirthNum;
        }
    }
}
