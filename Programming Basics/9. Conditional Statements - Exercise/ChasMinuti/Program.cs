using System;

namespace ChasMinuti
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hour = int.Parse(Console.ReadLine());
            int Minutes = int.Parse(Console.ReadLine());

            int Hour1 = Hour + 1;
            if (Hour1 == 24)
            {
                Hour1 = 0;
            }

            int Minuutes15 = Minutes + 15;

            if (Minuutes15<60)
            {
                Console.WriteLine($"{ Hour}:{Minuutes15}");
            }
            else
            {
                if (Minuutes15-60 >= 10)
                {
                                     
                    Console.WriteLine($"{ Hour1}:{Minuutes15 - 60}");
                }
                else
                {
                    
                    Console.WriteLine($"{ Hour1}:0{Minuutes15 - 60}");
                }

                
               
            }
        }
    }
}
