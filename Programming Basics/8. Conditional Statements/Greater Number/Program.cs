using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            if (Num1 >= Num2)
            {
                Console.WriteLine(Num1);
            }
            else
            {
                Console.WriteLine(Num2);
            }
        }
    }
}
