using System;

namespace _55
{
    class Program
    {
        static void Main(string[] args)
        {
            int Goal = 10000;
            int TotalSteps = 0;
            bool isGoal = false;
            bool isHome = false;

            while (!isGoal&&!isHome)
            {
                string Comand = Console.ReadLine();
                int DaySteps = 0;

                if (Comand == "Going home")
                {
                    isHome = true;
                    DaySteps = int.Parse(Console.ReadLine());
                }
                else
                {
                    DaySteps = int.Parse(Comand);
                }

                TotalSteps += DaySteps;

                if (TotalSteps>=Goal)
                {
                    isGoal = true;
                }

               
            }
            if (TotalSteps >= Goal)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{Goal - TotalSteps} more steps to reach goal.");
            }


        }
    }
}
