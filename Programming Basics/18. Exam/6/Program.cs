using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double medCountWinter = double.Parse(Console.ReadLine());
            

            double TotalMed = 0;

            while (true)
            {
                string nameBee = Console.ReadLine();
                
                if (nameBee== "Winter has come")
                {
                    break;
                }

                double MedMonth = 0;
                for (int i = 1; i <= 6; i++)
                {
                    MedMonth += double.Parse(Console.ReadLine());
                }
                if(MedMonth<0)
                {
                    Console.WriteLine($"{nameBee} was banished for gluttony");
                }
                TotalMed += MedMonth;
                if (TotalMed>=medCountWinter)
                {
                    break;
                }

            }

            if(TotalMed>=medCountWinter)
            {
                Console.WriteLine($"Well done! Honey surplus {(TotalMed-medCountWinter):f2}.");
            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {(medCountWinter-TotalMed):f2}.");
            }

           
        }
    }
}
