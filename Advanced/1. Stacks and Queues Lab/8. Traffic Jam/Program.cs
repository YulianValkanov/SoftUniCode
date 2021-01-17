using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            int Count = 0;

            int countCarPassed = 0;

            while (input!="end")
            {
               

                if (input=="green")
                {
                    
                    if (cars.Count>=n)
                    {

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");

                            countCarPassed++;
                        }
                    }
                    else
                    {
                        int carsStops = cars.Count;

                        for (int i = 0; i < carsStops; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");

                            countCarPassed++;
                        }

                        carsStops = 0;

                    }


                    


                    
                }
                else
                {
                    Count++;

                    cars.Enqueue(input);
                }

                
                input = Console.ReadLine();
            }

            Console.WriteLine($"{countCarPassed} cars passed the crossroads.");
        }
    }
}
