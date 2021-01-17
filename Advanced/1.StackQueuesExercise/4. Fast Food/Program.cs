using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int Quantity = int.Parse(Console.ReadLine());
           
            int[] Input= Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(Input);

           

            int bigestOrder = 0;

            while (orders.Count>0)
            {
                int currentOrder = orders.Peek();

                if (Quantity-currentOrder>=0)
                {
                    Quantity -= currentOrder;

                    if (orders.Dequeue()>bigestOrder)
                    {
                        bigestOrder = currentOrder;
                    }
                    
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(bigestOrder);


            if (orders.Count>0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
           
            
        }
    }
}
