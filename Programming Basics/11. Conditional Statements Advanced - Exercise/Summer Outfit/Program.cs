using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());
            string Text = Console.ReadLine();

            switch (Text)
            {
                case ("Morning"):
                    if (10 <= C && C <= 18)
                    {
                        Console.WriteLine($"It's {C} degrees, get your Sweatshirt and Sneakers.");
                    }
                    else if (18 < C && C <= 24)
                    {
                        Console.WriteLine($"It's {C} degrees, get your Shirt and Moccasins.");
                    }
                    else if (C >= 25)
                    {
                        Console.WriteLine($"It's {C} degrees, get your T-Shirt and Sandals.");
                    }
                    break;

                case ("Afternoon"):
                    if (10 <= C && C <= 18)
                    {
                        Console.WriteLine($"It's {C} degrees, get your Shirt and Moccasins.");
                    }
                    else if (18 < C && C <= 24)
                    {
                        Console.WriteLine($"It's {C} degrees, get your T-Shirt and Sandals.");
                    }
                    else if (C >= 25)
                    {
                        Console.WriteLine($"It's {C} degrees, get your Swim Suit and Barefoot.");
                    }
                    break;

                case ("Evening"):
                    if (10 <= C && C <= 18)
                    {
                        Console.WriteLine($"It's {C} degrees, get your Shirt and Moccasins.");
                    }
                    else if (18 < C && C <= 24)
                    {
                        Console.WriteLine($"It's {C} degrees, get your Shirt and Moccasins.");
                    }
                    else if (C >= 25)
                    {
                        Console.WriteLine($"It's {C} degrees, get your Shirt and Moccasins.");
                    }
                    break;
            }

           
        }
    }
}
