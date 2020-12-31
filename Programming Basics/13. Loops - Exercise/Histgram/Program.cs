using System;

namespace Histgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Group1 = 0;
            int Group2 = 0;
            int Group3 = 0;
            int Group4 = 0;
            int Group5 = 0;

            

            for (int i = 1; i <= n; i++)
            {
                int Num = int.Parse(Console.ReadLine());

                if(Num<200)
                {
                    Group1++;
                    
                }
                else if (Num>=200&&Num<=399)
                {
                    Group2++;
                }
                else if (Num >= 400 && Num <= 599)
                {
                    Group3++;
                }
                else if (Num >= 600 && Num <= 799)
                {
                    Group4++;
                }
                else if (Num >= 800 )
                {
                    Group5++;
                }
                
            }

            double SumGrop = Group1 + Group2 + Group3 + Group4 + Group5;
            double P1 = Group1 / SumGrop * 100;
            double P2 = Group2 / SumGrop * 100;
            double P3 = Group3 / SumGrop * 100;
            double P4 = Group4 / SumGrop * 100;
            double P5 = Group5 / SumGrop * 100;




            Console.WriteLine($"{P1:f2}%");
            Console.WriteLine($"{P2:f2}%");
            Console.WriteLine($"{P3:f2}%");
            Console.WriteLine($"{P4:f2}%");
            Console.WriteLine($"{P5:f2}%");
        }
    }
}
