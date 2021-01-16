using System;

namespace Problem_1._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double TotalPrice = 0;
            double CurrentPrice = 0;

            string Input = Console.ReadLine();

            while (Input!= "special"&&Input!= "regular")
            {

                CurrentPrice = double.Parse(Input)*1.2;

                if (CurrentPrice<0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    TotalPrice += CurrentPrice;
                }

                

                Input = Console.ReadLine();
            }

            double totalPriceWithoutTaxes = 0;

            totalPriceWithoutTaxes = TotalPrice / 1.2;

            double Taxes = totalPriceWithoutTaxes * 0.2;

            if (Input== "special")
            {              
                TotalPrice = TotalPrice * 0.9;
            }

            if (TotalPrice==0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {(totalPriceWithoutTaxes):f2}$");
                Console.WriteLine($"Taxes: { (Taxes):f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: { TotalPrice:f2}$");


            }
        }
    }
}
