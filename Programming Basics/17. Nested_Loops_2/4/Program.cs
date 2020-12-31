using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

            int Juli = int.Parse(Console.ReadLine());
            int Count = 0;
            double AllSum = 0;

            while (true)
            {
                Count++;
                double Sum = 0;
                string Name = Console.ReadLine();
                if(Name=="Finish")
                {
                    break;
                }
                for (int i = 1; i <= Juli; i++)
                {
                    double Ocenka = double.Parse(Console.ReadLine());
                    Sum += Ocenka;
                }
                Console.WriteLine($"{Name} - {Sum/Juli:f2}.");
                AllSum += Sum/Juli;
            }



            double Result = AllSum / (Count - 1);

            Console.WriteLine($"Student's final assessment is {Result:f2}.");
        }
    }
}
