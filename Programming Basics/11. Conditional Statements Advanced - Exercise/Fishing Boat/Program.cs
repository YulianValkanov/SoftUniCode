using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {

            int Budjet = int.Parse(Console.ReadLine());
            string Sezon = Console.ReadLine();
            int Count = int.Parse(Console.ReadLine());
            double Prise = 0;
            double Discount = 0;

            switch(Sezon)
            {
                case ("Spring"):
                    if (Count<=6)
                    {
                        Discount = 0.1;
                    }
                    else if (Count<=11)
                    {
                        Discount = 0.15;
                    }
                    else if (Count >=12)
                    {
                        Discount = 0.25;
                    }
                    Prise = 3000;
                    break;

                case ("Summer"):
                case ("Autumn"):
                    if (Count <= 6)
                    {
                        Discount = 0.1;
                    }
                    else if (Count <= 11)
                    {
                        Discount = 0.15;
                    }
                    else if (Count >= 12)
                    {
                        Discount = 0.25;
                    }
                    Prise = 4200;
                    break;

                case ("Winter"):
                    if (Count <= 6)
                    {
                        Discount = 0.1;
                    }
                    else if (Count <= 11)
                    {
                        Discount = 0.15;
                    }
                    else if (Count >= 12)
                    {
                        Discount = 0.25;
                    }
                    Prise = 2600;
                    break;
            }

            double FinalPrice = (Prise * (1 - Discount) );

            bool Chetno = (Count % 2 == 0);
            if (Chetno && (Sezon!= "Autumn"))
            {
                FinalPrice *= 0.95;
            }
            else
            {
                
            }

            double Ostatak = Budjet - FinalPrice;
            
            if (Ostatak>=0)
            {
                Console.WriteLine($"Yes! You have {Ostatak:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Ostatak*-1:f2} leva.");
            }

           
        }
    }
}
