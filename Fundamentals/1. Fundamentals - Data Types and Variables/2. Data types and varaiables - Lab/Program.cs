using System;

namespace _2._Data_types_and_varaiables___Lab
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.Write("Length: ");
            double Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Height = double.Parse(Console.ReadLine());
           double V = (Length + Width + Height) ;
            Console.Write($"Pyramid Volume: {V:f2}");


        }

    } 
}

