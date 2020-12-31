using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string imput = Console.ReadLine();
            int Sum = 0;
            
            while(imput!="Stop")
            {
                int CurrNum = int.Parse(imput);
                Sum += CurrNum;
                imput = Console.ReadLine();
               
            }
            Console.WriteLine(Sum);

        }
    }
}
