using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Angry_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRating = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int EntryPoint = int.Parse(Console.ReadLine());

            string typeEating = Console.ReadLine();

            string typePrice = Console.ReadLine();

            int totalLeft = 0;

            int totalRight = 0;

            int currentNumber = priceRating[EntryPoint];

            for (int i = 0; i < EntryPoint; i++)
            {
                if (typePrice== "positive"&&typeEating== "cheap")
                {
                    if (priceRating[i]>0&&priceRating[i]<currentNumber)
                    {
                        totalLeft += priceRating[i];
                    }
                }
                else if ((typePrice == "positive" && typeEating == "expensive"))
                {
                    if (priceRating[i] > 0 && priceRating[i] >= currentNumber)
                    {
                        totalLeft += priceRating[i];
                    }
                }
                else if (typePrice== "negative"&& typeEating == "cheap")
                {
                    if (priceRating[i] < 0 && priceRating[i] < currentNumber)
                    {
                        totalLeft += priceRating[i];
                    }
                }
                else if (typePrice == "negative" && typeEating == "expensive")
                {
                    if (priceRating[i] < 0 && priceRating[i] >= currentNumber)
                    {
                        totalLeft += priceRating[i];
                    }
                }
                else if (typePrice== "all"&& typeEating == "cheap")
                {
                    if (priceRating[i] < currentNumber)
                    {
                        totalLeft += priceRating[i];
                    }
                }
                else if (typePrice == "all" && typeEating == "expensive")
                {
                    if (priceRating[i] >= currentNumber)
                    {
                        totalLeft += priceRating[i];
                    }
                }
            }
           

            for (int i = EntryPoint+1; i < priceRating.Count; i++)
            {
                if (typePrice == "positive" && typeEating == "cheap")
                {
                    if (priceRating[i] > 0 && priceRating[i] < currentNumber)
                    {
                        totalRight += priceRating[i];
                    }
                }
                else if ((typePrice == "positive" && typeEating == "expensive"))
                {
                    if (priceRating[i] > 0 && priceRating[i] >= currentNumber)
                    {
                        totalRight += priceRating[i];
                    }
                }
                else if (typePrice == "negative" && typeEating == "cheap")
                {
                    if (priceRating[i] < 0 && priceRating[i] < currentNumber)
                    {
                        totalRight += priceRating[i];
                    }
                }
                else if (typePrice == "negative" && typeEating == "expensive")
                {
                    if (priceRating[i] < 0 && priceRating[i] >= currentNumber)
                    {
                        totalRight += priceRating[i];
                    }
                }
                else if (typePrice == "all" && typeEating == "cheap")
                {
                    if (priceRating[i] < currentNumber)
                    {
                        totalRight += priceRating[i];
                    }
                }
                else if (typePrice == "all" && typeEating == "expensive")
                {
                    if (priceRating[i] >= currentNumber)
                    {
                        totalRight += priceRating[i];
                    }
                }
            }

            if (totalLeft>=totalRight)
            {
                Console.WriteLine($"Left - {totalLeft}");
            }
            else
            {
                Console.WriteLine($"Right - {totalRight}");
            }

         
        }
    }
}
