﻿using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            double result = Area(a, b);

            Console.WriteLine(result);
        }

        private static double Area(double a, double b)
        {


            return a * b;
        }

       
    }
}
