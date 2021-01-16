using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!").ToList();

            string[] comands = Console.ReadLine().Split(" ");

            while (comands[0]!="Go")
            {
                switch (comands[0])
                {
                    case "Urgent":
                        string item = comands[1];
                        if (products.Contains(item)==false)
                        {
                            products.Insert(0, item);
                        }

                        break;

                    case "Unnecessary":
                        string ItemTho = comands[1];
                        products.Remove(ItemTho);

                        break;

                    case "Correct":
                        string oldItem = comands[1];
                        string newItem = comands[2];

                        if (products.Contains(oldItem))
                        {
                            int index =products.IndexOf(oldItem);
                            products[index] = newItem;
                        }

                        break;

                    case "Rearrange":
                        string ItemNEW = comands[1];

                        if (products.Contains(ItemNEW))
                        {
                            products.Remove(ItemNEW);
                            products.Add(ItemNEW);
                        }
                        break;
                }


                comands = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(", ",products));
        }
    }
}
