using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string BigestKeg = string.Empty;
            double BigestVolume = 0;

            for (int i = 1; i <= n; i++)
            {
                string Model = Console.ReadLine();
                double Radius = double.Parse(Console.ReadLine());
                int Haight = int.Parse(Console.ReadLine());

                double Volume = Math.PI  * Math.Pow(Radius,2) * Haight;

                if (Volume>=BigestVolume)
                {
                    BigestVolume = Volume;
                    BigestKeg = Model;
                }
            }
            Console.WriteLine(BigestKeg);
        }
    }
}
