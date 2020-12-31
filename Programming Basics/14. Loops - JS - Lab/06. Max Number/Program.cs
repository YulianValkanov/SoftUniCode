using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int Count = 0;
            int MaxNum = int.MinValue;

            while(Count<N)
            {
                int Num = int.Parse(Console.ReadLine());
                if (Num>MaxNum)
                {
                    MaxNum = Num;
                }
                Count++;
                
            }
            Console.WriteLine(MaxNum);


        }
    }
}
