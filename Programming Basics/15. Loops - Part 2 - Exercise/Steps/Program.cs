using System;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {

            int Golal = 10000;
            int TotalSteps = 0;
            bool isReacher = false;
            bool isGoinghome = false;

            while(!isReacher&&!isGoinghome)
            {
                string imput = Console.ReadLine();
                int DaySteps = 0;

                if (imput== "Going home")
                {
                    isGoinghome = true;
                    DaySteps = int.Parse(Console.ReadLine());
                }
                else
                {
                    DaySteps = int.Parse(imput);
                }
                
                TotalSteps += DaySteps;

                if (TotalSteps>=Golal)
                {
                    isReacher = true ;
                }
              
            }

            if (isReacher)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{Golal-TotalSteps} more steps to reach goal.");
            }



        }
    }
}
