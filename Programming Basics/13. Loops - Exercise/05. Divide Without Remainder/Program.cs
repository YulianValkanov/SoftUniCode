using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            int FirstGroup = 0;
            int SecondGroup = 0;
            int TirthGroup = 0;

            double P1 = 0.00;
            double P2 = 0.00;
            double P3 = 0.00;

            for (int i = 1; i <= n; i++)
            {
                int Num = int.Parse(Console.ReadLine());  
                
                if(Num%2==0)
                {
                    FirstGroup++;
                }
                if (Num % 3 == 0)
                {
                    SecondGroup++;
                }
                if (Num % 4 == 0)
                {
                    TirthGroup++;
                }
            }
            P1 = FirstGroup*1.0 / n * 100;
            P2 = SecondGroup*1.0 / n * 100;
            P3 = TirthGroup*1.0 / n * 100;

            Console.WriteLine($"{P1:f2}%");
            Console.WriteLine($"{P2:f2}%");
            Console.WriteLine($"{P3:f2}%");
        }
    }
}
