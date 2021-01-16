using System;

namespace _10._Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int Power = int.Parse(Console.ReadLine());
            int Distance = int.Parse(Console.ReadLine());
            int ExoctionFactor = int.Parse(Console.ReadLine());

            int Count = 0;
            double TonPower = Power*0.5;

            while (Power>=Distance)
            {
                Count++;
                Power -= Distance;

                if (Power==TonPower&&ExoctionFactor!=0)
                {
                    Power /= ExoctionFactor;
                }
            }

            Console.WriteLine(Power);
            Console.WriteLine(Count);
        }
    }
}
