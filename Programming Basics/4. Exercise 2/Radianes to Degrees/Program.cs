using System;

namespace Radianes_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {

            double Rad = double.Parse(Console.ReadLine());
            double Degrees = Rad * 180 / Math.PI;

            Console.WriteLine(Math.Round(Degrees));
        }
    }
}
