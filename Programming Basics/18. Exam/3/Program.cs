using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string TypeFlower = Console.ReadLine();
            int CountFlowers = int.Parse(Console.ReadLine());
            string Season = Console.ReadLine();
            double Med = 0;

            switch(TypeFlower)
            {
                case "Sunflower":
                    if(Season== "Spring")
                    {
                        Med = 10;
                    }
                    else if(Season == "Summer")
                    {
                        Med = 8 * 1.1 ;
                    }
                    else if (Season == "Autumn")
                    {
                        Med = 12*0.95;
                    }
                    break;
                case "Daisy":
                    if (Season == "Spring")
                    {
                        Med = 12*1.1;
                    }
                    else if (Season == "Summer")
                    {
                        Med = 8 * 1.1;
                    }
                    else if (Season == "Autumn")
                    {
                        Med = 6 * 0.95;
                    }
                    break;
                case "Lavender":
                    if (Season == "Spring")
                    {
                        Med = 12;
                    }
                    else if (Season == "Summer")
                    {
                        Med = 8 * 1.1;
                    }
                    else if (Season == "Autumn")
                    {
                        Med = 6 * 0.95;
                    }
                    break;
                case "Mint":
                    if (Season == "Spring")
                    {
                        Med = 10*1.1;
                    }
                    else if (Season == "Summer")
                    {
                        Med = 12 * 1.1;
                    }
                    else if (Season == "Autumn")
                    {
                        Med = 6 * 0.95;
                    }
                    break;
            }

            double TotalMed = Med * CountFlowers;
            Console.WriteLine($"Total honey harvested: {TotalMed:f2}");
        }
    }
}
