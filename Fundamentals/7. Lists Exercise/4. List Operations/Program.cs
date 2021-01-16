using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();


            while (true)
            {
                string[] comands = Console.ReadLine().Split(" ");

                if (comands[0]=="End")
                {
                    Console.WriteLine(string.Join(" ",list));
                    break;
                }
                else if (comands[0]=="Add")
                {
                    list.Add(int.Parse(comands[1]));
                }
                else if (comands[0] == "Insert")
                {
                    int Number = int.Parse(comands[1]);
                    int Index = int.Parse(comands[2]);

                    if (isValidIndex(Index,list.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(Index, Number);
                    }
                }
                else if (comands[0] == "Remove")
                {
                    int Index = int.Parse(comands[1]);

                    if (isValidIndex(Index,list.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(Index);
                    }
                }
                else if (comands[0] == "Shift")
                {
                    int rotations = int.Parse(comands[2]);
                    if (comands[1]=="left")
                    {
                        for (int i = 0; i < rotations; i++)
                        {

                            int FirtElement = list[0];
                            for (int j = 0; j < list.Count-1; j++)
                            {
                                list[j] = list[j + 1];
                            }
                            list[list.Count - 1] = FirtElement;
                        }
                    }
                    else if (comands[1] == "right")
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            int LastElement = list[list.Count-1];
                            for (int j = list.Count-1; j > 0; j--)
                            {
                                list[j] = list[j - 1];
                            }
                            list[0] = LastElement;
                        }
                    }
                }
            }


            
        }
        public static bool isValidIndex(int index, int count)
        {
            return index > count || index < 0;
        }
    }
}
