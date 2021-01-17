using System;
using System.Collections.Generic;

namespace _1._Stacks_and_Queues_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();

            Stack<string> InputStack = new Stack<string>();

            for (int i = 0; i < Input.Length; i++)
            {
                InputStack.Push(Input[i].ToString());
            }

            foreach (var item in InputStack)
            {
                Console.Write(item);
            }
        }
    }
}
