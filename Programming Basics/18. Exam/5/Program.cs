using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {

            int CountBee = int.Parse(Console.ReadLine());
            int healtBeer = int.Parse(Console.ReadLine());
            int AtacBeer = int.Parse(Console.ReadLine());


            while (true)
            {
                CountBee -= AtacBeer;
                healtBeer -= CountBee*5;
                if(healtBeer<=0)
                {
                    Console.WriteLine($"Beehive won! Bees left {CountBee}.");
                    break;
                }
                if (CountBee < 100)
                {
                    if(CountBee>=0)
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left {CountBee}.");
                    }
                    else
                    {
                        Console.WriteLine("The bear stole the honey! Bees left 0.");
                    }
                    
                    break;
                }

            }

           
        }
    }
}
