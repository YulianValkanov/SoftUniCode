using System;

namespace Tata
{
    class Program
    {
        static void Main(string[] args)
        {

            int Shirina = int.Parse(Console.ReadLine());
            int Daljina = int.Parse(Console.ReadLine());
            int S = Shirina * Daljina;
            int Pises = S/1;

            bool Stop = false;
            bool Finish = false;

           
            int Count = 0;

            while(!Stop&&!Finish)
            {
                String Comand = (Console.ReadLine());
                int CountNum = 0;

                if (Comand=="STOP")
                {
                    Stop = true;
                }
                else
                {
                    CountNum = int.Parse(Comand);
                }
                Count += CountNum;
                if(Count>=Pises)
                {
                    Finish = true;
                }
                

            }
            if (Count <= Pises)
            {
                Console.WriteLine($"{Pises - Count} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Count - Pises} pieces more.");
            }


        }
    }
}
