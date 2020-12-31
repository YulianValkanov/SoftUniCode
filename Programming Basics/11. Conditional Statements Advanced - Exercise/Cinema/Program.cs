using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string Type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double Price = 0;

            if (Type == "Premiere")
                Price = 12;
            else if (Type == "Normal")
                Price = 7.5;
            else
                Price = 5;

            double FilanlPrice = Price * r * c;

            Console.WriteLine($"{FilanlPrice:f2} leva");
        }
    }
}
