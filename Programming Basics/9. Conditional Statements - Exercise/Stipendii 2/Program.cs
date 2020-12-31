using System;


class Program
{
    static void Main(string[] args)
    {

        double Incom = double.Parse(Console.ReadLine());
        double Result = double.Parse(Console.ReadLine());
        double MinSalary = double.Parse(Console.ReadLine());

        double Souchal = MinSalary * 0.35;
        double Exelent = Result * 25;

        if (Souchal > Exelent)
        {
            if (Incom < MinSalary)
            {
                if (Result > 4.5)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(Souchal),0} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
        else
        {
            if (Result >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(Exelent),0} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }




    }
}
