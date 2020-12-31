using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            Double Sum = 0.0;
            int Count = 0;

            while(Count<12)
            {
                Count++;
                double Anual = double.Parse(Console.ReadLine());
                if (Anual<4)
                {
                    continue;
                }
                Sum += Anual;
            }



            Console.WriteLine($"{Name} graduated. Average grade: {Sum/12:f2}");
        }
    }
}
