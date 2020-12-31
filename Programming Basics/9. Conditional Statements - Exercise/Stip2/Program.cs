using System;


class Program
{
    static void Main(string[] args)
    {

        double Incom = double.Parse(Console.ReadLine());
        double Result = double.Parse(Console.ReadLine());
        double MinSalary = double.Parse(Console.ReadLine());

        double Souchal = 0;
        double Exelent = 0;


        if (Incom >= MinSalary)
        {
            Souchal = 0;
        }
        else
        {
            if (Result > 4.5)
            {
                Souchal = Math.Floor((MinSalary * 0.35));
            }
            else
            {
                Souchal = 0;
            }
        }

        if (Result >= 5.5)
        {
            Exelent = Math.Floor(Result * 25);
        }
        else
        {
            Exelent = 0;
        }

        if (Exelent > Souchal)
        {
            if (Exelent > 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Exelent} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
        else
        {
            if (Souchal > 0)
            {
                Console.WriteLine($"You get a Social scholarship {Souchal} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }



    }
}
