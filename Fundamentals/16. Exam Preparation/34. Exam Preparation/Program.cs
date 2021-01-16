using System;
using System.Collections.Generic;
using System.Linq;

namespace _34._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string input = Console.ReadLine();


            while (input!= "Generate")
            {
                string[] comands = input.Split(">>>",StringSplitOptions.RemoveEmptyEntries);

                string comand = comands[0];
                if (comand== "Contains")
                {
                    string word = comands[1];
                    if (key.Contains(word))
                    {
                        Console.WriteLine($"{key} contains {word}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                }
                else if (comand== "Flip")
                {
                    string word = comands[1];
                    int startIndex = int.Parse(comands[2]);
                    int endIndex = int.Parse(comands[3]);

                   

                    if (word== "Upper")
                    {
                        string word1 = key.Substring(0, startIndex);
                        string word2 = key.Substring(startIndex, endIndex-startIndex).ToUpper();
                         string word3=   key.Substring(endIndex);

                        key = word1 + word2 + word3;

                        Console.WriteLine(key);
                    }
                    else if (word=="Lower")
                    {
                        string word1 = key.Substring(0, startIndex);
                        string word2 = key.Substring(startIndex, endIndex - startIndex).ToLower();
                        string word3 = key.Substring(endIndex);

                        key = word1 + word2 + word3;
                        Console.WriteLine(key);
                    }
                    
                }
                else if (comand == "Slice")
                {
                    int startIndex = int.Parse(comands[1]);
                    int endIndex = int.Parse(comands[2]);

                    string word1 = key.Substring(0, startIndex);
                    
                    string word3 = key.Substring(endIndex);
                    key = word1  + word3;
                    Console.WriteLine(key);
                }

                    input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");

        }
    }
}
