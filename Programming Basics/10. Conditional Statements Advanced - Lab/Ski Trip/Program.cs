using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int Days = int.Parse(Console.ReadLine());
            string KindRoom = Console.ReadLine();
            string Value = Console.ReadLine();

            if (Days>0)
            {
                Days = Days - 1;
            }
            else
            {
                Days = Days;
            }

            double Discount = 0;
            double Price = 0;

            if (KindRoom == "room for one person")
                Price = 18 * Days;
            else if (KindRoom == "apartment")
                Price = 25 * Days;
            else if (KindRoom == "president apartment")
                Price = 35 * Days;

            
            switch (KindRoom)
            {
                case ("room for one person"):
                    Discount = 0;
                    break;

                case ("apartment"):
                   if ( Days<10)
                    {
                        Discount = 0.3;
                    }
                   else if (Days<=15)
                    {
                        Discount = 0.35;
                    }
                   else if (Days>15)
                    {
                        Discount = 0.5;
                    }
                    break;
                case ("president apartment"):
                    if (Days < 10)
                    {
                        Discount = 0.1;
                    }
                    else if (Days <= 15)
                    {
                        Discount = 0.15;
                    }
                    else if (Days > 15)
                    {
                        Discount = 0.2;
                    }
                    break;

            }


         
            double FinalPrice = Price *(1- Discount);

            if (Value == "positive")
            {
                FinalPrice *=1.25;
            }
            else if (Value == "negative")
            {
                FinalPrice*=0.9;
            }

            Console.WriteLine($"{FinalPrice:f2}");
        }
    }
}
