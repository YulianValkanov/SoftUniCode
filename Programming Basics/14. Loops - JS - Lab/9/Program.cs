using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int Count = 0;
            int Skasan = 0;
            double Sum = 0;
            bool Izkliuchen = false;

            while(Count<12)
            {
                Count++;
                double Anual = double.Parse(Console.ReadLine());
                if (Anual>=4)
                {
                    Sum += Anual;
                }
                else
                {
                    Skasan++;
                    if (Skasan>=2)
                    {
                        Izkliuchen = true;
                        break;
                    }
                   
                }
            }
            if (Izkliuchen == true)
            {
                Console.WriteLine($"{Name} has been excluded at {Count - 1} grade");
            }
            else
            {
                Console.WriteLine($"{Name} graduated. Average grade: {Sum / 12:f2}");
            }
        }
    }
}
