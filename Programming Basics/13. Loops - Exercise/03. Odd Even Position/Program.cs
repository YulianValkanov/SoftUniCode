using System;

namespace _03._Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double EvenSum = 0;
            double EvenMax = double.MinValue;
            double EvenMin = double.MaxValue;

            double OddSum = 0;
            double OddMax = double.MinValue;
            double OddMin = double.MaxValue;


            for (int i = 0; i < n; i++)
            {
                double Num = double.Parse(Console.ReadLine());

                if (Num % 2 == 0)
                {
                    EvenSum += Num;

                    if (Num > EvenMax)
                    {
                        EvenMax = Num;
                    }

                    if (Num < EvenMin)

                    {
                        EvenMin = Num;
                    }
                }
                else
                {
                    OddSum += Num;
                    

                    if (Num > OddMax)
                    {
                        OddMax = Num;
                    }
                    if (Num < OddMin)

                    {
                        OddMin = Num;
                    }
                }

            }
            
            Console.WriteLine($"OddSum={OddSum:f2},");
            Console.WriteLine($"OddMin={OddMin:f2},");
            Console.WriteLine($"OddMax={OddMax:f2},");

            Console.WriteLine($"EvenSum={EvenSum:f2},");
            Console.WriteLine($"EvenMin={EvenMin:f2},");
            Console.WriteLine($"EvenMax={EvenMax:f2},");
        }
    }
}
