using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine().Split();

            Stack<string> numberStack = new Stack<string>(Input.Reverse());

            

            while (numberStack.Count>1)
            {
                int LeftNumber = int.Parse(numberStack.Pop());
                string sign = numberStack.Pop();
                int RightNumber = int.Parse(numberStack.Pop());
                int result = 0;

                if (sign=="+")
                {
                    result = LeftNumber + RightNumber;
                    numberStack.Push(result.ToString());
                }
                else
                {
                    result = LeftNumber - RightNumber;
                    numberStack.Push(result.ToString());
                }
            
            }
            Console.WriteLine(string.Join(" ",numberStack));
        }
    }
}
