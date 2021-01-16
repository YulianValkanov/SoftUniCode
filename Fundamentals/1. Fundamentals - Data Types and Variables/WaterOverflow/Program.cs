using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int Capacity = 255;

            int Now = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int Input = int.Parse(Console.ReadLine());

                if (Input<=Capacity)
                {
                    Capacity -= Input;
                    Now += Input;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(Now);
        }
    }
}

