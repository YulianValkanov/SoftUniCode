using System;

namespace _2._Fundamentals___Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNum = int.Parse(Console.ReadLine());
            int SecondNum = int.Parse(Console.ReadLine());
            int ThirthNum = int.Parse(Console.ReadLine());
            int ForthNum = int.Parse(Console.ReadLine());

            int Total = (FirstNum + SecondNum) / ThirthNum * ForthNum;

            Console.WriteLine(Total);
        }
    }
}
