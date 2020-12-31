using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {

            double Age = double.Parse(Console.ReadLine());
            string Kind = Console.ReadLine();

            if (Kind == "m")
            {
                if (Age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else
            {
                if (Age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}