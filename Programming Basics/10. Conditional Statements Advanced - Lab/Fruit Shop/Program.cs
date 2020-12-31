using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            string Frud = Console.ReadLine();
            string Day = Console.ReadLine();
            double Quantity = double.Parse(Console.ReadLine());
            double Price = 0;

            switch (Day)
            {
                case ("Monday"):
                case ("Tuesday"):
                case ("Wednesday"):
                case ("Thursday"):
                case ("Friday"):
                    switch (Frud)
                    {
                        case ("banana"):
                            Price = 2.5;
                            break;
                        case ("apple"):
                            Price = 1.2;
                            break;
                        case ("orange"):
                            Price = 0.85;
                            break;
                        case ("grapefruit"):
                            Price = 1.45;
                            break;
                        case ("kiwi"):
                            Price = 2.70;
                            break;
                        case ("pineapple"):
                            Price = 5.50;
                            break;
                        case ("grapes"):
                            Price = 3.85;
                            break;
                    }

                    break;
            

                case ("Saturday"):
                case ("Sunday"):
                    switch (Frud)
                    {
                        case ("banana"):
                            Price = 2.7;
                            break;
                        case ("apple"):
                            Price = 1.25;
                            break;
                        case ("orange"):
                            Price = 0.9;
                            break;
                        case ("grapefruit"):
                            Price = 1.6;
                            break;
                        case ("kiwi"):
                            Price = 3;
                            break;
                        case ("pineapple"):
                            Price = 5.60;
                            break;
                        case ("grapes"):
                            Price = 4.20;
                            break;
                    }

                    break;
            }
            double Final =(Price * Quantity);


            if (Final!=0)
            {
                Console.WriteLine($"{Final:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }




        }
    }
}
