using System;
using System.Collections.Generic;

namespace _6_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());

                Dictionary<string, Dictionary<string, int>> colors = new Dictionary<string, Dictionary<string, int>>();

                for (int i = 0; i < n; i++)
                {
                    string[] currentArray = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string color = currentArray[0];

                    string[] allClothes = currentArray[1].Split(",");


                    for (int j = 0; j < allClothes.Length; j++)
                    {

                        string currentCloud = allClothes[j];

                        Dictionary<string, int> clothes = new Dictionary<string, int>();

                        clothes.Add(currentCloud, 1);



                        if (colors.ContainsKey(color))
                        {
                            if (colors[color].ContainsKey(currentCloud))
                            {
                                colors[color][currentCloud]++;
                            }
                            else
                            {
                                colors[color].Add(currentCloud, 1);
                            }
                        }
                        else
                        {
                            colors.Add(color, clothes);
                        }
                    }

                }
                string[] finalSearch = Console.ReadLine().Split(" ");

                string finalColor = finalSearch[0];
                string finalClothes = finalSearch[1];


                foreach (var colorItem in colors)
                {
                    Console.WriteLine(colorItem.Key+ " clothes:");

                    foreach (var item in colorItem.Value)
                    {
                        

                        if (colorItem.Key==finalColor&&item.Key==finalClothes)
                        {
                            Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                          
                        }
                        else
                        {
                            Console.WriteLine($"* {item.Key} - {item.Value}");
                        }

                    }
                }
            }
        }
    }
}
