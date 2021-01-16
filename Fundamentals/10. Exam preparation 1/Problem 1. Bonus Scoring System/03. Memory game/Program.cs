using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequences = Console.ReadLine().Split(" ").ToList();

            string[] input = Console.ReadLine().Split(" ");

            int Moves = 0;

            while (input[0]!="end")
            {
                           
                Moves++;
               

                int firstIndex = int.Parse(input[0]);
                int secondIndex = int.Parse(input[1]);

                if (firstIndex<0||
                    firstIndex>=sequences.Count||
                    secondIndex<0||
                    secondIndex>=sequences.Count||
                    firstIndex==secondIndex)
                {
                    int middleIndex = sequences.Count / 2;

                    string middleWord = $"-{Moves}a";

                    //chetno//
                    if (middleIndex%2==0)
                    {
                       
                    }
                    //nechetno//
                    else
                    {
                        middleIndex -= 1;
                    }

                    sequences.Insert(middleIndex, middleWord);
                    sequences.Insert(middleIndex, middleWord);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                  
                }
                else if (sequences[firstIndex] == sequences[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequences[firstIndex]}!");

                    string wordToRemove = sequences[firstIndex];
                    sequences.Remove(wordToRemove);                 
                    sequences.Remove(wordToRemove);

                    if (sequences.Count <= 1)
                    {
                        Console.WriteLine($"You have won in {Moves} turns!");
                        break;
                    }

                }
                else if (sequences[firstIndex] != sequences[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }





                input = Console.ReadLine().Split(" ");
            }
            if (sequences.Count>1)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequences));
            }
            
        }
    }
}
