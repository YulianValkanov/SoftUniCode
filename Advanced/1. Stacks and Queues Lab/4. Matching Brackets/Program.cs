using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {

            string Input = Console.ReadLine();
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5

            Stack<int> Indexes = new Stack<int>();

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i]=='(')
                {
                    Indexes.Push(i);
                }
                else if (Input[i]==')')
                {
                    int StartIndex = Indexes.Pop();
                    int Count = i - StartIndex + 1;

                    Console.WriteLine(Input.Substring(StartIndex, Count) ); 
                }
            }
            
        }
    }
}
