using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Counter = 0;
            double Balance = 0.0;

            while(Counter<N)
            {
                double Amount = double.Parse(Console.ReadLine());
                if (Amount<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                    Balance += Amount;
                    Console.WriteLine($"Increase: {Amount:f2}");
                    Counter++;  
            }

            Console.WriteLine($"Total: {Balance:f2}");
        }
    }
}
