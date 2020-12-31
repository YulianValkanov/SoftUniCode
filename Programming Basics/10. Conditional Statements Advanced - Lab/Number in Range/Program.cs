using System;

namespace Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num = int.Parse(Console.ReadLine());

            if (-100<=Num&&Num<=100&&Num!=0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
