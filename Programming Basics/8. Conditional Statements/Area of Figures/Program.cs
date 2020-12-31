using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string Kind = Console.ReadLine();

            if (Kind == "square")
            {
                double a = double.Parse(Console.ReadLine());
                a = a * a;
                Console.WriteLine($"{a:f2}");
            }
            else if (Kind== "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = a * b;
                Console.WriteLine(($"{S:f2}"));
            }
            else if (Kind == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                a = a * a * Math.PI;
                Console.WriteLine(($"{a:f2}"));
            }
            else if(Kind== "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = a * b/2;
                Console.WriteLine(($"{S:f2}"));
            }
        }
    }
}
