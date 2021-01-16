using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<string> area = Console.ReadLine().Split(" ").ToList();

            List<string> comands = Console.ReadLine().Split(" ").ToList();
         

            while (comands[0]!="3:1")
            {
                if (comands[0] == "merge")
                {
                    int startIndex = int.Parse(comands[1]);
                    int endIndex = int.Parse(comands[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (endIndex > area.Count - 1)
                    {
                        endIndex = area.Count - 1;
                    }

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        area[startIndex] = area[startIndex] + area[startIndex + 1];

                        area.RemoveAt(startIndex + 1);
                    }

                }
                else if (comands[0] == "divide")
                {
                    int index = int.Parse(comands[1]);

                    int partitions = int.Parse(comands[2]);

                    string currentWord = area[index];

                    double howDivide = currentWord.Length / partitions;

                    string[] divideWord = new string [partitions];


                    for (int i = 0; i < partitions; i++)
                    {
                        for (int j = 0; j < currentWord.Length; j++)
                        {
                            if ((j + 1) / howDivide <= (i + 1) &&(j+1)/howDivide>i)
                            {

                                divideWord[i] += currentWord[j];
                            }
                          
                        }
                    }

                    area.RemoveAt(index);

                    for (int r = 0; r < divideWord.Length; r++)
                    {
                        area.Add(divideWord[r]);
                    }
                 


                }
                comands = Console.ReadLine().Split(" ").ToList();

            }

            Console.WriteLine(string.Join(" ", area));

          

        }

        
    }
}
