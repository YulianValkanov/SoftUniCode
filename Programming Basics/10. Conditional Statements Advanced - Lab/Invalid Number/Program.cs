using System;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num = int.Parse(Console.ReadLine());

            if ((100<=Num && Num<=200)||Num==0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            
        }
    }
}
