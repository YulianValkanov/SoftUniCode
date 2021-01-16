using System;

namespace MID_EXAM_01._07._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int dayliPlunder = int.Parse(Console.ReadLine());

            double expectedPlunder = double.Parse(Console.ReadLine());

            double Plunder = 0;

            for (int i = 1; i <= days; i++)
            {
                Plunder += dayliPlunder;

                if (i%3==0&&i%5==0)
                {
                    Plunder += dayliPlunder*0.5;
                    Plunder = Plunder * 0.7;
                }
                else if (i%3==0)
                {
                    Plunder += dayliPlunder * 0.5;
                }
                else if (i%5==0)
                {
                    Plunder = Plunder * 0.7;
                }
            }

            

            if (Plunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {Plunder:f2} plunder gained.");
            }
            else if (Plunder<expectedPlunder)
            {
                double persentage = Plunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {persentage:f2}% of the plunder.");
            }
           

            

        }
    }
}
