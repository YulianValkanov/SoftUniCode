using System;

namespace Jorney
{
    class Program
    {
        static void Main(string[] args)
        {
            double Budjet = double.Parse(Console.ReadLine());
            string Season = Console.ReadLine();
            double Price = 0;
            string Plase = "";
            string Where = "";

           switch(Season)
            {
                case ("summer"):
                    if (Budjet<=100)
                    {
                        Price = 0.3 * Budjet;
                        Plase = "Bulgaria";
                        Where = "Camp";
                    }
                    else if (Budjet<=1000)
                    {
                        Price = 0.4 * Budjet;
                        Plase = "Balkans";
                        Where = "Camp";
                    }
                    else if (Budjet > 1000)
                    {
                        Price = 0.9 * Budjet;
                        Plase = "Europe";
                        Where = "Hotel";
                    }
                    break;

                case ("winter"):
                    if (Budjet <= 100)
                    {
                        Price = 0.7 * Budjet;
                        Where = "Hotel";
                        Plase = "Bulgaria";
                    }
                    else if (Budjet <= 1000)
                    {
                        Price = 0.8 * Budjet;
                        Where = "Hotel";
                        Plase = "Balkans";
                    }
                    else if (Budjet > 1000)
                    {
                        Price = 0.9 * Budjet;
                        Where = "Hotel";
                        Plase = "Europe";
                    }
                    break;
            }


            Console.WriteLine($"Somewhere in {Plase}");
            Console.WriteLine($"{Where} - {Price:f2}");
        }
    }
}
