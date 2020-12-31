using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            Double x1 = double.Parse(Console.ReadLine());
            Double y1 = double.Parse(Console.ReadLine());
            Double x2 = double.Parse(Console.ReadLine());
            Double y2 = double.Parse(Console.ReadLine());

            Double Daljina = Math.Abs(x1 - x2);
            Double DShirina = Math.Abs(y1 - y2);

            Double Lice = Daljina * DShirina;
            Double Perimeter = Daljina*2 + DShirina*2;

            Console.WriteLine($"{Lice:f2}");
            Console.WriteLine($"{Perimeter:f2}");
        }
    }
}
