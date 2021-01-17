using System;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> open = new Stack<char>();

            string input = Console.ReadLine();

            foreach (char item in input)
            {
                if (item=='('||item=='{'||item=='[')
                {
                    open.Push(item);
                }
                else
                {
                    if (item == ')' && open.Peek() =='(')
                    {
                        open.Pop();
                       
                    }
                   
                    else if (item == '}' && open.Peek() == '{')
                    {
                        open.Pop();
                    }
                    else if (item == ']' && open.Peek() == '[')
                    {
                        open.Pop();
                    }
                }
            }

            if (open.Count>0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
