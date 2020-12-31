using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {

            string City = Console.ReadLine();
            double Count = double.Parse(Console.ReadLine());
            double Comission = 0;

            switch (City)
            {
                case ("Sofia"):
                    if (0<=Count&&Count<=500)
                    {
                        Comission = 0.05;
                    }
                    else if (500 <= Count && Count <= 1000)
                    {
                        Comission = 0.07;
                    }
                    else if (1000 <= Count && Count <= 10000)
                    {
                        Comission = 0.08;
                    }
                    else if (10000 <= Count)
                    {
                        Comission = 0.12;
                    }
                    else
                    {
                        Comission = 0;
                    }
                    break;

                case ("Varna"):
                    if (0 <= Count && Count <= 500)
                    {
                        Comission = 0.045;
                    }
                    else if (500 <= Count && Count <= 1000)
                    {
                        Comission = 0.075;
                    }
                    else if (1000 <= Count && Count <= 10000)
                    {
                        Comission = 0.1;
                    }
                    else if (10000 <= Count)
                    {
                        Comission = 0.13;
                    }
                    else
                    {
                        Comission = 0;
                    }
                    break;

                case ("Plovdiv"):
                    if (0 <= Count && Count <= 500)
                    {
                        Comission = 0.055;
                    }
                    else if (500 <= Count && Count <= 1000)
                    {
                        Comission = 0.08;
                    }
                    else if (1000 <= Count && Count <= 10000)
                    {
                        Comission = 0.12;
                    }
                    else if (10000 <= Count)
                    {
                        Comission = 0.145;
                    }
                    else
                    {
                        Comission = 0;
                    }
                    break;
            }

            double Finish = Count * Comission;

            if (Finish==0||Finish==-0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{Finish:f2}");
            }
            
        }
    }
}
