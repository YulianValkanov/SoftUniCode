using System;

namespace WordSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double RecordSec = double.Parse(Console.ReadLine());
            double LongMiters = double.Parse(Console.ReadLine());
            double TimeforMeterSec = double.Parse(Console.ReadLine());

            double LateCount =Math.Floor(LongMiters/15);
            double Late = LateCount * 12.5;
            double NewTime = LongMiters * TimeforMeterSec + Late;

            if (RecordSec<=NewTime)
            {
                Console.WriteLine($"No, he failed! He was {(NewTime-RecordSec):f2} seconds slower.");
                
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {NewTime:f2} seconds.");
            }
            
        }
    }
}
