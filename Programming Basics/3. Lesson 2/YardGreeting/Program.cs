using System;

namespace YardGreeting
{
    class Program
    {
        static void Main(string[] args)
        {

            Double Yards = Double.Parse(Console.ReadLine());

            Double TotalPrise = Yards * 7.61;

            Double Discount = TotalPrise * 0.18;

            Double FinalPrise = TotalPrise - Discount;

            Console.WriteLine($"The final price is: {FinalPrise:f2} lv.");
            Console.WriteLine($"The discount is: {Discount:f2} lv.");
        }
    }
}
