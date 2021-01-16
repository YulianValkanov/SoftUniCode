using System;

namespace _1._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstWorker = int.Parse(Console.ReadLine());
            int SecondWorker = int.Parse(Console.ReadLine());
            int ThirdhWorker = int.Parse(Console.ReadLine());

            double NumPeople = int.Parse(Console.ReadLine());

            double FullWorkers = FirstWorker + SecondWorker + ThirdhWorker;


            double hoursWork = Math.Ceiling( NumPeople / FullWorkers);

            double hourdBreak = Math.Floor(hoursWork / 3);

            double allWork = hoursWork + hourdBreak;

            Console.WriteLine($"Time needed: {allWork:f0}h.");



        }
    }
}
