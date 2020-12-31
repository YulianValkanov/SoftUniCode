using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

            double StartPopulatin = double.Parse(Console.ReadLine());
            int Yars = int.Parse(Console.ReadLine());

  

            
            double Life = 0.00;
            double Dead = 0.00;
            double Leave = 0.00;

           
            for (int i = 1; i <= Yars; i++)
            {
                if(i%5==0)
                {
                    Life = (Math.Floor(StartPopulatin / 10.0) * 2);
                    StartPopulatin += Life;

                    Leave = Math.Floor(StartPopulatin / 50.0) * 5;
                    StartPopulatin -= Leave;

                    Dead = (Math.Floor(StartPopulatin / 20.0) * 2);
                    StartPopulatin -= Dead;
                }
                else
                {
                    Life = (Math.Floor(StartPopulatin/10.0)*2);
                    StartPopulatin += Life;
                    Dead = (Math.Floor(StartPopulatin / 20.0) * 2);
                    StartPopulatin -= Dead;
                }
               
            }


            Console.WriteLine($"Beehive population: {StartPopulatin}");
        }
    }
}
