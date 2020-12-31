using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            double HourExam = double.Parse(Console.ReadLine());
            double MinuteExam = double.Parse(Console.ReadLine());
            double HourComming = double.Parse(Console.ReadLine());
            double MinuteComming = double.Parse(Console.ReadLine());

            double TimeExam = HourExam * 60 + MinuteExam;
            double TimeComming = HourComming * 60 + MinuteComming;
            double Time = TimeExam - TimeComming;

            if (Time<0&&Time>-60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Time*-1} minutes after the start");
            }
            else if (Time<=-60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Floor(Time/60*-1)}:{Time%60*-1} hours after the start” ");
            }
            else if (Time==0)
            {
                Console.WriteLine("On time");            
            }
            else if (Time>0 &&Time<=30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Time} minutes before the start");
            }
            else if (Time > 30)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{Time/60:f0}: {(Time%60)} hours before the start");
            }

            Console.WriteLine(Time);
    
        }
    }
}
