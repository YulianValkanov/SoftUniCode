using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(" ");

            Stack<string> text = new Stack<string>();

            Stack<int> LastOperation = new Stack<int>();
            string LastTextAdded = "";
            List<string> LastTextDeleted = new List<string>();

            for (int i = 0; i < n; i++)
            {
                int comand = int.Parse(input[0]);

                if (comand==1)
                {
                    string textAdded =input[1];

                    for (int j = textAdded.Length-1; j >= 0; j--)
                    {
                        text.Push(textAdded[j].ToString());
                    }

                    LastOperation.Push(1);
                    LastTextAdded = textAdded;
                }
                else if (comand==2)
                {
                    int countDeleting = int.Parse(input[1]);

                    for (int j = 0; j < countDeleting; j++)
                    {
                        LastTextDeleted.Add(text.Pop());
                      
                    }
                    LastOperation.Push(2);

                   
                }
                else if (comand==3)
                {
                    int index = int.Parse(input[1]);

                    int Counter = 0;
                    foreach (var item in text)
                    {
                        Counter++;
                        if (Counter==index)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                else if (comand==4)
                {
                    if (LastOperation.Peek()==1)
                    {
                        for (int j = 0; j < LastTextAdded.Length; j++)
                        {
                            text.Pop();
                        }
                        LastOperation.Pop();
                    }
                    else if (LastOperation.Peek()==2)
                    {
                        for (int j = LastTextDeleted.Count-1; j >= 0; j--)
                        {
                            text.Push(LastTextDeleted[j]);

                        }
                        LastOperation.Pop();
                    }
                }

                if (i==n-1)
                {
                    break;
                }

                Console.WriteLine(string.Join(", ",text));
                input= Console.ReadLine().Split(" "); 
            }
        }
    }
}
