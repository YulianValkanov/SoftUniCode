using System;


    class Program
    {
        static void Main(string[] args)
        {

            double Time1 = double.Parse(Console.ReadLine());
            double Time2 = double.Parse(Console.ReadLine());
            double Time3 = double.Parse(Console.ReadLine());

            double SumTime = (Time1 + Time2 + Time3);

            double Minutes = Math.Floor(SumTime/60);

            double Seconds = SumTime % 60;

            if (Seconds < 10)
            {
                Console.WriteLine($"{Minutes}:0{Seconds}");
            }
            else
            {
                Console.WriteLine($"{Minutes}:{Seconds}");
            }
            
    }
}
