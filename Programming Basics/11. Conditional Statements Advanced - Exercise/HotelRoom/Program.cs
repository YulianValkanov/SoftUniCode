using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            string Month = Console.ReadLine();
            int Days = int.Parse(Console.ReadLine());
            double Studio = 0;
            double Apartment = 0;

            switch(Month)
            {
                case ("May"):
                case ("October"):
                    if (Days > 14)
                    {
                        Apartment = 65 * 0.9;
                    }
                    else
                    {
                        Apartment = 65;
                    }

                    if (Days>7&&Days<=14)
                    {
                        Studio = 50 * 0.95;
                    }
                    else if (Days>14)
                    {
                        Studio = 50 * 0.7;
                    }
                    else
                    {
                        Studio = 50;
                    }
                    break;

                case ("June"):
                case ("September "):
                    if (Days > 14)
                    {
                        Apartment = 68.70 * 0.9;
                    }
                    else
                    {
                        Apartment = 68.70;
                    }
                    if (Days > 14)
                    {
                        Studio = 75.20 * 0.8;
                    }
                    else
                    {
                        Studio = 75.20;
                    }
                    break;

                case ("July"):
                case ("August"):
                    Studio = 76;
                    if (Days>14)
                    {
                        Apartment = 77 * 0.9;
                    }
                    else
                    {
                        Apartment = 77;
                    }
                    break;

            }

            Console.WriteLine($"Apartment: {Apartment*Days:f2} lv.");
            Console.WriteLine($"Studio: {Studio*Days:f2} lv.");
        }
    }
}
