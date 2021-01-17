using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());
            int greenSec = greenLightSeconds;

           

            Queue<string> cars = new Queue<string>();

            string input = Console.ReadLine();

            bool isTrue = true;

            int count = 0;

            while (input!="END")
            {               
                
                if (input=="green")
                {
                    int carsCaunts = cars.Count;

                    for (int i = 0; i < carsCaunts; i++)
                    {
                        int currentCarCount = cars.Peek().Length;

                        if (greenSec-currentCarCount>=0)
                        {
                            greenSec -= currentCarCount;

                            cars.Dequeue();

                            count++;


                        }
                        else
                        {
                            if (greenSec+freeWindowSeconds-currentCarCount>=0)
                            {
                                greenSec = 0;
                                cars.Dequeue();
                                count++;
                                
                                break;
                            }
                            else
                            {
                                int lastIndex = greenSec + freeWindowSeconds;

                                string currentCar = cars.Peek();

                                Console.WriteLine("A crash happened!");

                                Console.WriteLine($"{currentCar} was hit at {currentCar[lastIndex].ToString()}.");


                                isTrue = false;

                                break;
                            }
                        }
                        

                    }

                    greenSec = greenLightSeconds;




                }
                else
                {
                    cars.Enqueue(input);
                }

                if (isTrue==false)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (isTrue==true)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
                
            }
        
        }
    }
}
