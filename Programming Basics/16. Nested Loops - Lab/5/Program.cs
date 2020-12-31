using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isEnaf = false;
            string destination = Console.ReadLine();
            int Bujet = int.Parse(Console.ReadLine());
            int Sum = 0;
            bool isEnd = false;

            while(!isEnd)
            {
                string destination = Console.ReadLine();
                if(destination=="End")
                {
                    isEnd = true;
                }
            }


            while (!isEnaf)
            {      
                int Spend = int.Parse(Console.ReadLine());
                Sum+= Spend;
                if(Sum>=Bujet)
                {
                    Console.WriteLine($"Going to {destination}!");
                    isEnaf = true;
                }
            }

            
            {

            }
            
        }
    }
}
