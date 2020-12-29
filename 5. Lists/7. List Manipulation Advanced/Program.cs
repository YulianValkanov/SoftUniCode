using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._List_Manipulation_Advanced
{


    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            bool isFinish = false;

            bool isChange = false;

          

            while (!isFinish)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    Console.WriteLine(String.Join(" ", Numbers));
                    isFinish = true;
                }
                else if (input[0] == "Add")
                {

                    isChange = true;
                    Numbers.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    isChange = true;
                    Numbers.Remove(int.Parse(input[1]));
                }
                else if (input[0] == "RemoveAt")
                {
                    isChange = true;
                    Numbers.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    isChange = true;
                    Numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                else if (input[0] == "Contains")
                {
                    
                  Console.WriteLine(Numbers.Contains(int.Parse(input[1])) ? "Yes" :  "No such");

                   
                }
                else if (input[0] == "PrintEven")
                {

                    Console.WriteLine(String.Join(" ",Numbers.Where(n=> n%2==0)));
                }
                else if (input[0] == "PrintOdd")
                {

                    Console.WriteLine(String.Join(" ", Numbers.Where(n => n % 2 == 1)));
                }
                else if (input[0] == "GetSum")
                {

                    Console.WriteLine(Numbers.Sum());
                }
                else if (input[0] == "Filter")
                {
                    string resulet = string.Empty;
                    switch (input[1])
                    {
                        case "<":
                            resulet = string.Join(" ", Numbers
                                .Where(n => n < int.Parse(input[2])));
                        break;
                        case ">":
                            resulet = string.Join(" ", Numbers
                              .Where(n => n > int.Parse(input[2])));
                            break;
                        case "<=":
                            resulet = string.Join(" ", Numbers
                              .Where(n => n <= int.Parse(input[2])));
                            break;
                        case ">=":
                            resulet = string.Join(" ", Numbers
                              .Where(n => n >= int.Parse(input[2])));
                            break;
                            
                    }
                    Console.WriteLine(resulet);
                }

            }
        }
    }
}

