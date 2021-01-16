using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string[] input = Console.ReadLine().Split(" - ",StringSplitOptions.RemoveEmptyEntries);

            
            while (input[0]!= "Craft!")
            {
                string comands = input[0];

                string item = input[1];

             
                if (comands == "Collect")
                {
                    if (!journal.Contains(item))
                    {
                        journal.Add(item);
                    }
                }
                else if (comands == "Drop")
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                }
                else if (comands == "Combine Items")
                {
                   
                    string[] secondItem = item.Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string OldeItem = secondItem[0];
                    string NewItem = secondItem[1];
                  

                    if (journal.Contains(OldeItem))
                    {
                        int index = journal.IndexOf(OldeItem);
                        journal.Insert(index+1, NewItem);
                    }

                }
                else if (comands=="Renew")
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                        journal.Add(item);
                    }
                }

                input = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
