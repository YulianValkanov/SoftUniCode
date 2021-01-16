using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parts = Console.ReadLine().Split("|").ToList();

            string[] imput = Console.ReadLine().Split(" ");

            
            

            while (imput[0]!="Done")
            {
                string comand = imput[0];
                string secondComand = imput[1];

                switch (comand)
                {
                    case "Move":
                       
                        int index = int.Parse(imput[2]);

                        

                        if (secondComand=="Left")
                        {
                            if (index>0&&index<parts.Count)
                            {
                                string currentWord = parts[index];
                                string beforeIndex = parts[index - 1];
                                parts[index - 1] = currentWord;
                                parts[index] = beforeIndex;
                            }
                        }
                        else if (secondComand == "Right")
                        {
                            if (index<parts.Count-1&&index>=0)
                            {
                                string currentWord = parts[index];
                                string afterIndex = parts[index + 1];
                                parts[index + 1] = currentWord;
                                parts[index] = afterIndex;
                            }
                        }

                        break;
                    case "Check":

                        if (secondComand== "Even")
                        {
                            List<string> EvenNumbers = new List<string>();

                            for (int i = 0; i < parts.Count; i++)
                            {
                                //even
                                if (i%2==0)
                                {
                                    EvenNumbers.Add(parts[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ",EvenNumbers));
                        }
                        else if (secondComand == "Odd")
                        {
                            List<string> OddNumbers = new List<string>();

                            for (int i = 0; i < parts.Count; i++)
                            {
                                //odd
                                if (i % 2 != 0)
                                {
                                    OddNumbers.Add(parts[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", OddNumbers));
                        }

                        break;
                }


                imput= Console.ReadLine().Split(" ");
            }
            Console.WriteLine("You crafted " + string.Join("",parts)+"!");
        }
    }
}
