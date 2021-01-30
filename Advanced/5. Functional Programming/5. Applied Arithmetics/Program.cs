using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string comand = Console.ReadLine();

            Func<int, int> aritmeticFunc = num => num;

            Action<List<int>> print = num => Console.WriteLine(string.Join(" ", num));

            while (comand!="end")
            {
                if (comand=="add")
                {
                    aritmeticFunc = num => num + 1;
                    numbers = numbers.Select(aritmeticFunc).ToList();
                }
                else if (comand=="multiply")
                {
                    aritmeticFunc = num => num * 2;
                    numbers = numbers.Select(aritmeticFunc).ToList();
                }
                else if (comand=="subtract")
                {
                    aritmeticFunc = num => num - 1;
                    numbers = numbers.Select(aritmeticFunc).ToList();
                }
                else if (comand=="print")
                {
                    print(numbers);
                   
                }


                comand = Console.ReadLine();
            }

           
        }
    }
}
