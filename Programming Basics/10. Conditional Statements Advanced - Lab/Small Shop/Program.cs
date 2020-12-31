using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            string Product = Console.ReadLine();
            string City = Console.ReadLine();
            double Quantity = double.Parse(Console.ReadLine());
            double Price = 0;

            switch(Product)
            {
                case ("coffee"):
                    switch(City)
                    {
                        case ("Sofia"):
                            Price = 0.5;
                            break;

                        case ("Plovdiv"):
                            Price = 0.4;
                            break;
                        case ("Varna"):
                            Price = 0.45;
                            break;
                    }

                    break;
                case ("water"):
                    switch (City)
                    {
                        case ("Sofia"):
                            Price = 0.8;
                            break;

                        case ("Plovdiv"):               
                        case ("Varna"):
                            Price = 0.7;
                            break;
                    }

                    break;
                case ("beer"):
                    switch (City)
                    {
                        case ("Sofia"):
                            Price = 1.20;
                            break;

                        case ("Plovdiv"):
                            Price = 1.15;
                            break;
                        case ("Varna"):
                            Price = 1.10;
                            break;
                    }

                    break;
                case ("sweets"):
                    switch (City)
                    {
                        case ("Sofia"):
                            Price = 1.45;
                            break;

                        case ("Plovdiv"):
                            Price = 1.3;
                            break;
                        case ("Varna"):
                            Price = 1.35;
                            break;
                    }

                    break;
                case ("peanuts"):
                    switch (City)
                    {
                        case ("Sofia"):
                            Price = 1.60;
                            break;

                        case ("Plovdiv"):
                            Price = 1.50;
                            break;
                        case ("Varna"):
                            Price = 1.55;
                            break;
                    }

                    break;
            }

            Console.WriteLine(Price * Quantity);
        }
    }
}
