using System;

namespace _3._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dice dise6 = new Dice();
            dise6.Sides = 6;

            for (int i = 0; i < 15; i++)
            {


                Console.WriteLine(dise6.Roll());
            }
        }
    }
}
