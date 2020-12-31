using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {

            string Kind = Console.ReadLine();
            double Count = double.Parse(Console.ReadLine());
            double Budget = double.Parse(Console.ReadLine());

            double Discount = 0;
            double Price = 0;

            switch(Kind)
            {
                case ("Roses"):
                    if (Count>80)
                    {
                        Discount = 0.9*5;
                    }
                    else
                    {
                        Discount = 5;
                    }
                    break;
                case ("Dahlias"):
                    if (Count > 90)
                    {
                        Discount = 0.85*3.80;
                    }
                    else
                    {
                        Discount = 3.80;
                    }
                    break;
                case ("Tulips"):
                    if (Count > 80)
                    {
                        Discount = 0.85*2.8;
                    }
                    else
                    {
                        Discount = 2.80;
                    }

                    break;
                case ("Narcissus"):
                    if (Count < 120)
                    {
                        Discount = 1.15*3;
                    }
                    else
                    {
                        Discount = 3;
                    }
                    break;
                case ("Gladiolus"):
                    if (Count < 80)
                    {
                        Discount = 1.2*2.5;
                    }
                    else
                    {
                        Discount = 2.5;
                    }
                    break;
            }

            Price = Count * Discount;
            double Ostatak = Budget - Price;

            if (Budget>=Price)
            {
                Console.WriteLine($"Hey, you have a great garden with {Count} {Kind} and {Ostatak:f2} leva left.");
            }
            else
            {
                {
                    Console.WriteLine($"Not enough money, you need {Ostatak*-1:f2} leva more.");
                }
            }

         
        }
    }
}
