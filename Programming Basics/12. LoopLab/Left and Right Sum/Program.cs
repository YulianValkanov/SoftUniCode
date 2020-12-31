using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cunt = int.Parse(Console.ReadLine());
            int Leftsum = 0;
            int Rightsum = 0;

            for (int i = 1; i <= Cunt; i++)
            {
                int LeftNum = int.Parse(Console.ReadLine());
                Leftsum += LeftNum;            
            }
            for (int i = 0; i < Cunt; i++)
            {
                int RightNum = int.Parse(Console.ReadLine());
                Rightsum += RightNum;
            }
            if (Leftsum == Rightsum)
            {
                Console.WriteLine($"Yes, sum = {Leftsum}");
            }
            else
            { 
                int diff = Math.Abs(Leftsum - Rightsum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
