using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int shards = 0;
            int fragments = 0;
            int motes = 0;


           SortedDictionary<string, int> articles = new SortedDictionary<string, int> { { "shards",0 }, { "fragments", 0 },{ "motes", 0 } };
            
            SortedDictionary<string, int> trach = new SortedDictionary<string, int>();

            while (shards < 250 && fragments < 250 && motes < 250)
            {
                List<string> imput = Console.ReadLine().ToLower().Split(" ").ToList();


                for (int i = 0; i < imput.Count / 2; i++)
                {
                    if (shards >= 250 || fragments >= 250 || motes >= 250)
                    {
                        break;
                    }
                    
                    string currentItem = imput[i * 2 + 1];

                    int currenResult = int.Parse(imput[i * 2]);

                    if (currentItem== "shards"||currentItem== "fragments"||currentItem== "motes")
                    {
                        if (currentItem == "shards")
                        {
                            shards += currenResult;
                            articles[currentItem] += currenResult;
                           
                        }
                        else if (currentItem == "fragments")
                        {
                            fragments += currenResult;
                            articles[currentItem] += currenResult;
                           
                        }
                        else if (currentItem == "motes")
                        {
                            motes += currenResult;
                            articles[currentItem] += currenResult;
                          
                        }

                       

                       
                    }
                    else
                    {
                        if (trach.ContainsKey(currentItem))
                        {
                            trach[currentItem] += currenResult;
                        }
                        else
                        {
                            trach.Add(currentItem, currenResult);
                        }
                    }

                   


                }
            }


            if (shards>=250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                articles["shards"] -= 250;
            }
            else if (fragments>=250)
            {
                Console.WriteLine("Valanyr obtained!");
                articles["fragments"] -= 250;
            }
            else if (motes>=250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                articles["motes"] -= 250; 
            }


            foreach (var item in articles.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in trach)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }






        }
    }
}
